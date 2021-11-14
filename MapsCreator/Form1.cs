using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MapsCreator
{
    public partial class Form1 : Form
    {
        double x1, y1, x2, y2;

        private void start()
        {
            gb_filterByType.Enabled = false;
            gb_filterByName.Enabled = false;
            gb_filterByCoordinates.Enabled = false;
            gb_filterByVoltage.Enabled = false;
            if (!File.Exists(File.ReadAllText("path.data")))
            {
                MessageBox.Show("Файл kml не найден. Укажите путь к файлу", "Файл не найден", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Kml Files|*.kml";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText("path.data", ofd.FileName);
                }
            }
        }

        private bool isFilteredByCoordinates(XmlNode xn)
        {
            
            if (!cb_filterByCoordinates.Checked)
                return true;
            if (xn.SelectSingleNode("Polygon") != null)
                return isStringInRectangle(xn.LastChild.LastChild.LastChild.SelectSingleNode("coordinates").InnerText, x1, y1, x2, y2);
            if (!xn.HasChildNodes || xn.LastChild.SelectSingleNode("coordinates") == null)
                return false;
            return isStringInRectangle(xn.LastChild.SelectSingleNode("coordinates").InnerText, x1, y1, x2, y2);
        }

        private bool isFilteredByType(XmlNode xn)
        {
            if (!cb_filterByType.Checked)
                return true;
            if (cb_typePoint.Checked && (xn.SelectSingleNode("Point") != null))
                return true;
            if (cb_typePolygon.Checked && (xn.SelectSingleNode("Polygon") != null))
                return true;
            if (cb_typeLineString.Checked && (xn.SelectSingleNode("LineString") != null))
                return true;
            return false;
        }

        private bool isFilteredByVoltage(XmlNode xn)
        {
            if (!cb_filterByVoltage.Checked)
                return true;
            if (xn.SelectSingleNode("styleUrl") == null)
                return false;
            string style = xn["styleUrl"].InnerText;
            switch (style)
            {
                case "#no_voltage":
                    return cb_novoltage.Checked;
                case "#0_4kv":
                    return cb_04.Checked;
                case "#6kv":
                    return cb_6.Checked;
                case "#10kv":
                    return cb_10.Checked;
                case "#35kv":
                    return cb_35.Checked;
                case "#110kv":
                    return cb_110.Checked;
                case "#220kv":
                    return cb_220.Checked;
                case "#500":
                    return cb_500.Checked;
                case "#sub_station":
                    return cb_substation.Checked;
                default:
                    return false;
            }
        }

        private bool isFilteredByName(XmlNode xn)
        {
            if (!cb_filterByName.Checked)
                return true;
            if (xn.SelectSingleNode("name") == null)
                return false;
            if (lbFilter.Items.Count == 0)
            {
                foreach (var itemNon in lbNonFilter.Items)
                {
                    if (xn["name"].InnerText.Replace("/", "_").Replace("\"", "").Contains(itemNon.ToString()))
                        return false;
                }
                return true;
            }
            else
            {
                foreach (var item in lbFilter.Items)
                {
                    if (xn["name"].InnerText.Replace("/", "_").Replace("\"", "").Contains(item.ToString()))
                    {
                        foreach (var itemNon in lbNonFilter.Items)
                        {
                            if (xn["name"].InnerText.Replace("/", "_").Replace("\"", "").Contains(itemNon.ToString()))
                                return false;
                        }
                        return true;
                    }
                }
                return false;
            }
        }

        private bool isInsideRectangle(double pointX, double pointY, double x1, double y1, double x2, double y2)
            // метод проверяет, находится ли входная точка внутри прямоугольника, огрниченного диагональю зданных точек
        {
            if (x1 < x2)
            {
                if (pointX < x1 || pointX > x2)
                    return false;
            }
            else
            {
                if (pointX < x2 || pointX > x1)
                    return false;
            }
            if (y1 < y2)
            {
                if (pointY < y1 || pointY > y2)
                    return false;
            }
            else
            {
                if (pointY < y2 || pointY > y1)
                    return false;
            }
            return true;
        }

        private bool isStringInRectangle(string input, double x1, double y1, double x2, double y2)
            // для переданной в метод строки, содержащей координаты метод выдает true, если хотя бы одна точка лежит в заданном прямоугольнике
        {
            string[] splitSpaces = input.Split(' ');
                foreach (string s in splitSpaces)
                {
                    string[] splitPoint = s.Split(',');
                if (splitPoint.Length > 1) {
                    double x = double.Parse(splitPoint[0].Replace('.', ','));
                    double y = double.Parse(splitPoint[1].Replace('.', ','));
                    if (isInsideRectangle(x, y, x1, y1, x2, y2))
                        return true;
                    }
                    
                }
            return false;
        }

        private async void startFilter()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(File.ReadAllText("path.data"));
            XmlElement xRoot = xml.DocumentElement;
            XmlNodeList elemList = xRoot.GetElementsByTagName("Placemark");
            int i = 0;
            int nodeCounter = 0;

            XmlDocument xml2 = new XmlDocument();
            xml2.Load("Шаблон.kml");
            XmlElement xRoot2 = xml2.DocumentElement;


            await Task.Run(() =>
            {
                foreach (XmlNode xn in elemList)
                {
                    if (isFilteredByCoordinates(xn) && isFilteredByType(xn) && isFilteredByName(xn) && isFilteredByVoltage(xn))
                    {
                        xRoot2.FirstChild.AppendChild(xRoot2.OwnerDocument.ImportNode(xn, true));
                        nodeCounter++;
                    }
                    i++;
                    if (i % 100 == 0)
                    {
                        progressBar1.Invoke(new Action(() => progressBar1.Value = (100 * i / elemList.Count)));
                        lbl_progress.Invoke(new Action(() => lbl_progress.Text = "Прогресс: узел " + i + " из " + elemList.Count));
                        lbl_selectedNodes.Invoke(new Action(() => lbl_selectedNodes.Text = "Выделено узлов: " + nodeCounter));
                    }
                }
            });

            progressBar1.Value = (100 * i / elemList.Count);
            lbl_progress.Text = "Прогресс: узел " + i + " из " + elemList.Count;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Kml Files|*.kml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                xml2.Save(sfd.FileName);
                MessageBox.Show("Количество выделенных узлов: " + nodeCounter, "Готово");

                //System.Diagnostics.Process.Start(sfd.FileName);
            }
            xml = null;
            xml2 = null;
            elemList = null;
            GC.Collect();
        }


        private void btnBegin_Click(object sender, EventArgs e)
        {
            if (!checkValid())
                return;
            string[] point1 = tbPoint1.Text.Split(' ');
            string[] point2 = tbPoint2.Text.Split(' ');
            x1 = double.Parse(point1[1].Replace('.', ','));
            y1 = double.Parse(point1[0].Replace('.', ','));
            x2 = double.Parse(point2[1].Replace('.', ','));
            y2 = double.Parse(point2[0].Replace('.', ','));
            startFilter();
        }

        private void tbFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbFilter.Items.Add(tbFilter.Text);
                tbFilter.SelectionStart = 0;
                tbFilter.SelectionLength = tbFilter.Text.Length;
                tbFilter.Focus();
            }
        }

        private void tbNonFilter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbNonFilter.Items.Add(tbNonFilter.Text);
                tbNonFilter.SelectionStart = 0;
                tbNonFilter.SelectionLength = tbNonFilter.Text.Length;
                tbNonFilter.Focus();
            }
        }

        private void cb_filterByVoltage_CheckedChanged(object sender, EventArgs e)
        {
            gb_filterByVoltage.Enabled = cb_filterByVoltage.Checked;
        }

        private void cb_filterByName_CheckedChanged(object sender, EventArgs e)
        {
            gb_filterByName.Enabled = cb_filterByName.Checked;
        }

        private void cb_filterByCoordinates_CheckedChanged(object sender, EventArgs e)
        {
            gb_filterByCoordinates.Enabled = cb_filterByCoordinates.Checked;
        }

        private void cb_filterByType_CheckedChanged(object sender, EventArgs e)
        {
            gb_filterByType.Enabled = cb_filterByType.Checked;
        }

        private bool checkValid()
        {
            if (!cb_filterByCoordinates.Checked && !cb_filterByName.Checked && !cb_filterByType.Checked && !cb_filterByVoltage.Checked)
            {
                MessageBox.Show("Не выбран фильтр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
                
            if (cb_filterByName.Checked && lbFilter.Items.Count == 0 && lbNonFilter.Items.Count == 0)
            {
                MessageBox.Show("Не задан фильтр по наименованию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorColor(gb_filterByName, 100, 4);
                return false;
            }

            if (cb_filterByVoltage.Checked && !cb_novoltage.Checked && !cb_04.Checked && !cb_6.Checked && !cb_10.Checked && !cb_35.Checked && 
                !cb_110.Checked && !cb_220.Checked && !cb_500.Checked && !cb_substation.Checked)
            {
                MessageBox.Show("Не задан фильтр по напряжению", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorColor(gb_filterByVoltage, 100, 4);
                return false;
            }

            if (cb_filterByCoordinates.Checked && (tbPoint1.Text == "" || tbPoint2.Text == ""))
            {
                MessageBox.Show("Не заданы координаты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorColor(gb_filterByCoordinates, 100, 4);
                return false;
            }

            if (cb_filterByType.Checked && !cb_typePoint.Checked && !cb_typeLineString.Checked && !cb_typePolygon.Checked)
            {
                MessageBox.Show("Не задан фильтр по типу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorColor(gb_filterByType, 100, 4);
                return false;
            }
            return true;
        }

        // метод подсвечивает GroupBox, в котором заданы некорректные данные
        private async void errorColor(GroupBox gb, int time, int cycleNumber)
        {
            Color temp = gb.BackColor;
            for (int i = 0; i < cycleNumber; i++)
            {
                gb.BackColor = Color.Red;
                await Task.Delay(time);
                gb.BackColor = temp;
                await Task.Delay(time);
            }
        }

        public Form1()
        {
            InitializeComponent();
            start();
        }
    }
}
