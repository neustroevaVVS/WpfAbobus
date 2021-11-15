using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAbobus
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /// <summary> Кнопка Проверка ФИО </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>

            if (textBox1.Text != "")
            {
                string[] str1 = textBox1.Text.Split(' ');

                //str1 = Convert.ToString(str1).Trim();
                while (true)
                {
                    if (str1[str1.Length - 1] == "")
                    {
                        str1[2] = Convert.ToString(str1).Trim(new Char[] { ' ', '*', '.' });
                    }
                    else break;
                }

                if (str1.Length == 3)
                {
                    //str1 = Convert.ToString(str1[2].Trim());
                    if (textBox1.Text == "" || (str1.Length > 3 || str1.Length < 2) || (char.IsLower(str1[0][0]))
                        || (char.IsLower(str1[1][0])) || (char.IsLower(str1[2][0]))) MessageBox.Show("В строке 'ФИО' ошибка");
                    //else MessageBox.Show("В строке 'ФИО' нет ошибок");
                }
                else if (str1.Length == 2)
                {
                    if (textBox1.Text == "" || (str1.Length > 3 || str1.Length < 2) || (char.IsLower(str1[0][0]))
                        || (char.IsLower(str1[1][0]))) MessageBox.Show("В строке 'ФИО' ошибка");
                    //else MessageBox.Show("В строке 'ФИО' нет ошибок");
                }
                else MessageBox.Show("В строке 'ФИО' ошибка");



                /// <summary> Кнопка Проверка Даты Рождения </summary>
                /// <param name="sender"></param>
                /// <param name="e"></param>
                string str2 = textBox2.Text;

                if (textBox2.Text.Length == 10)
                {
                    while (true)
                    {
                        foreach (var ch in str2)
                        {
                            if (ch == '.')
                            {
                                str2 = str2.Replace(ch, '0');
                            }
                        }
                        bool success = long.TryParse(str2, out long birth);

                        if (!success)
                        {
                            MessageBox.Show("В строке 'Дата рождения' ошибка");
                            break;
                        }
                        //else MessageBox.Show("Дата Рождения введена корректно");

                        string[] strSplit = textBox2.Text.Split('.');


                        if ((strSplit[0].Length == 2 && strSplit[1].Length == 2 &&
                            strSplit[2].Length == 4))
                        {
                            //MessageBox.Show("Дата рождения введена корректно");
                        }
                        else MessageBox.Show("В строке 'Дата рождения' ошибка");

                        //День
                        if ((Convert.ToInt32(strSplit[0]) > 31) &&
                            (Convert.ToInt32(strSplit[0]) < 1)) MessageBox.Show("В строке 'Дата рождения' ошибка");
                        //else MessageBox.Show("Дата Рождения введена корректно");

                        //Месяц
                        if ((Convert.ToInt32(strSplit[1]) > 12) &&
                            (Convert.ToInt32(strSplit[1]) < 1)) MessageBox.Show("В строке 'Дата рождения' ошибка");
                        //else MessageBox.Show("Дата Рождения введена корректно");

                        //Год
                        if ((Convert.ToInt32(strSplit[2]) > 2020) &&
                            (Convert.ToInt32(strSplit[2]) < 1900)) MessageBox.Show("В строке 'Дата рождения' ошибка");
                        //else MessageBox.Show("Дата Рождения введена корректно");

                        break;
                    }
                }
                else MessageBox.Show("В строке 'Дата рождения' ошибка");
            }
        }
    }
}

