using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Net;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;

namespace ТЭК
{
    public partial class EquipmentListForm : Form
    {
        public class Point
        {
            public double x { get; set; }
            public double y { get; set; }

            public Point(double _x, double _y) { x = _x; y = _y; }
        }

        public EquipmentListForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        List<Point> ListWithPoinsOfYouLocation = new List<Point>();
        List<Point> ListWithPoinsOfEarthquake = new List<Point>();
        List<Point> ListWithPoinsOfFloods = new List<Point>();
        List<Point> ListWithPoinsOfFires = new List<Point>();

        GMapOverlay ListOfYouLocation = new GMapOverlay("YouLocation");
        GMapOverlay ListOfEarthquake = new GMapOverlay("Earthquake");
        GMapOverlay ListOfFloods = new GMapOverlay("Floods");
        GMapOverlay ListOfFires = new GMapOverlay("Fires");

        private void EquipmentListForm_Load(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            // Настройки для компонента GMap
            gmap.Bearing = 0;
            // Перетаскивание правой кнопки мыши
            gmap.CanDragMap = true;
            // Перетаскивание карты левой кнопкой мыши
            gmap.DragButton = MouseButtons.Left;

            gmap.GrayScaleMode = true;

            // Все маркеры будут показаны
            gmap.MarkersEnabled = true;
            // Максимальное приближение
            gmap.MaxZoom = 18;
            // Минимальное приближение
            gmap.MinZoom = 2;
            // Курсор мыши в центр карты
            gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionWithoutCenter;

            // Отключение нигативного режима
            gmap.NegativeMode = false;
            // Разрешение полигонов
            gmap.PolygonsEnabled = true;
            // Разрешение маршрутов
            gmap.RoutesEnabled = true;
            // Скрытие внешней сетки карты
            gmap.ShowTileGridLines = false;
            // При загрузке 10-кратное увеличение
            gmap.Zoom = 5;
            // Убрать крестик по центру 
            gmap.ShowCenter = false;
            // Изменение размеров
            // gmap.Dock = DockStyle.Fill;

            // Чья карта используется
            gmap.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleMap;

            // Загрузка этой точки на карте
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new GMap.NET.PointLatLng(55.7522, 37.6156);

            // Создаём новый список маркеров
            GMapOverlay markersOverlay = new GMapOverlay("markers");

        }

        private void загрузитьКоординатыToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            List<Point> points = new List<Point>();
            // Имя выбранного файла
            string FileName = "";

            // Пользователь выбирает файл на компьютере
            try
            {
                OpenFileDialog OpenDialogorChoiceAFile = new OpenFileDialog();
                // Форматы, которые может выбрать пользователь
                OpenDialogorChoiceAFile.Filter = "Text Files (*.TXT; *.CSV;|*.TXT; *.CSV;|All files(*.*)|*.*";

                // Путь, который перед ним откроется
                OpenDialogorChoiceAFile.InitialDirectory = @"C:\Users";

                OpenDialogorChoiceAFile.Title = "Выбирите файл для подгрузки данных";

                if (OpenDialogorChoiceAFile.ShowDialog() == DialogResult.OK)
                    // Сохранили имя и формат выбранного файла
                    FileName = OpenDialogorChoiceAFile.FileName.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }

            // Отсекаем имя и формат от друг друга
            string[] FileNameAndFormat = FileName.Split(new char[] { '.' });

            // Если пользователь выбран текстовый файл
            if (FileNameAndFormat[1] == "txt")
            {
                // Читаем в массив все строки файла
                string[] ArrayOfStringsWithCoor = File.ReadAllLines(FileName, Encoding.GetEncoding(1251));

                // От 0 до количества строк в файле
                for (int i = 0; i < ArrayOfStringsWithCoor.Length; i++)
                {
                    // Парсим строку на поля структуры
                    string[] OneStringWithCoor = ArrayOfStringsWithCoor[i].Split(new char[] { ';' });
                    // Добавляем эту структуру 
                    points.Add(new Point(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
                }
                MessageBox.Show("Данные успешно прочитаны");
            }

            // Если пользователь выбрал ксв файл - другого выбора не может быть
            else
            {
                // Читаем все строки
                using (StreamReader ReaderCSCFile = new StreamReader(FileName, Encoding.GetEncoding(1251)))
                {
                    while (!ReaderCSCFile.EndOfStream)
                    {
                        string ArrayOfStringsWithCoor = ReaderCSCFile.ReadLine();
                        string[] OneStringWithCoor = ArrayOfStringsWithCoor.Split(new char[] { ';' });
                        points.Add(new Point(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
                    }
                }
                MessageBox.Show("Данные успешно прочитаны");
            }

        }

        private void EarthquakeCB_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Add(ListOfEarthquake);
            if (EarthquakeCB.Checked)
            {
                string[] ArrayOfStringsWithCoor = File.ReadAllLines(@"D:\project C#\ТЭК\Date\Earthquake.txt");
                for (int i = 0; i < ArrayOfStringsWithCoor.Length; i++)
                {

                    string[] OneStringWithCoor = ArrayOfStringsWithCoor[i].Split(new char[] { ';' });
                    ListWithPoinsOfEarthquake.Add(new Point(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
                }

                for (int i = 0; i < ListWithPoinsOfEarthquake.Count; i++)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng
                        (ListWithPoinsOfEarthquake[i].x, ListWithPoinsOfEarthquake[i].y), GMarkerGoogleType.brown_small);
                    marker.ToolTip = new GMapRoundedToolTip(marker);

                    ListOfEarthquake.Markers.Add(marker);
                }
            }
            else
            {
                gmap.Overlays.Remove(ListOfEarthquake);
                ListOfEarthquake.Clear();
                ListWithPoinsOfEarthquake.Clear();
            }
        }

        private void FloodsCB_Click(object sender, EventArgs e)
        {

        }

        private void FiresCB_Click(object sender, EventArgs e)
        {
            gmap.Overlays.Add(ListOfFires);
            if (FiresCB.Checked)
            {
                string[] ArrayOfStringsWithCoor = File.ReadAllLines(@"D:\project C#\ТЭК\Date\Fires.txt");
                for (int i = 0; i < ArrayOfStringsWithCoor.Length; i++)
                {
                    string[] OneStringWithCoor = ArrayOfStringsWithCoor[i].Split(new char[] { ';' });
                    ListWithPoinsOfFires.Add(new Point(Convert.ToDouble(OneStringWithCoor[0]), Convert.ToDouble(OneStringWithCoor[1])));
                }

                for (int i = 0; i < ListWithPoinsOfFires.Count; i++)
                {
                    GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng
                        (ListWithPoinsOfFires[i].x, ListWithPoinsOfFires[i].y), GMarkerGoogleType.red);
                    marker.ToolTip = new GMapRoundedToolTip(marker);

                    ListOfFires.Markers.Add(marker);
                }
            }
            else
            {
                gmap.Overlays.Remove(ListOfFires);
                ListOfFires.Clear();
                ListWithPoinsOfFires.Clear();
            }
        }

        private void youlocationBTN_Click(object sender, EventArgs e)
        {
            double x, y;
            x = double.Parse(textBox1.Text);
            y = double.Parse(textBox2.Text);

            gmap.Overlays.Remove(ListOfYouLocation);
            ListOfYouLocation.Clear();

            gmap.Overlays.Add(ListOfYouLocation);
            GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.black_small);
            marker.ToolTip = new GMapRoundedToolTip(marker);

            marker.ToolTipText = "Ваша позиция";
            ListOfYouLocation.Markers.Add(marker);
        }
    }
}
