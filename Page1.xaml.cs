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

namespace generic_list
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {

        public Page1()
        {
            InitializeComponent();

        }
        int count = 0;
        List<string> lname = new List<string>();
        List<int> lage = new List<int>();
        List<string> lgender = new List<string>();
        List<string> lqualification = new List<string>();
        List<string> ldesignation = new List<string>();
        List<int> lsalary = new List<int>();
        List<string> lcountry = new List<string>();
        List<int> lnumber = new List<int>();


        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int age = Convert.ToInt32(txtage.Text);
            int sal = Convert.ToInt32(txtsal.Text);
            int num = Convert.ToInt32(txtcontact.Text);

            lname.Add(txtname.Text);
            lage.Add(age);
            lqualification.Add(txtqua.Text);
            ldesignation.Add(txtdes.Text);
            lsalary.Add(sal);
            lcountry.Add(txtcon.Text);
            lnumber.Add(num);

            if (rd.Tag == "true")
            {
                lgender.Add("Male");
            }
            else
            {
                lgender.Add("Female");
            }

            MessageBoxResult res = MessageBox.Show("Registered Successfully", "Success", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if (res == MessageBoxResult.OK)
            {
                txtname.Clear();
                txtage.Clear();
                txtqua.Clear();
                txtdes.Clear();
                txtcon.Clear();
                txtsal.Clear();
                txtcontact.Clear();
                rd1.IsChecked = false;
                rd2.IsChecked = false;
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            btn1.Visibility = Visibility.Hidden;
            lbl1.Visibility = Visibility.Hidden;

            btnbk.Visibility = Visibility.Visible;
            btnfd.Visibility = Visibility.Visible;


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            count--;

            {
                btnfd.IsEnabled = true;
                if (count == 1)
                {
                    // MessageBox.Show(item.ToString());
                    txtname.Text = lname[0].ToString();
                    txtage.Text = lage[0].ToString();
                    txtcon.Text = lcountry[0].ToString();
                    txtcontact.Text = lnumber[0].ToString();
                    txtdes.Text = ldesignation[0].ToString();
                    txtqua.Text = lqualification[0].ToString();
                    txtsal.Text = lsalary[0].ToString();
                }
                else if (count == 2)
                {
                    txtname.Text = lname[1].ToString();
                    txtage.Text = lage[1].ToString();
                    txtcon.Text = lcountry[1].ToString();
                    txtcontact.Text = lnumber[1].ToString();
                    txtdes.Text = ldesignation[1].ToString();
                    txtqua.Text = lqualification[1].ToString();
                    txtsal.Text = lsalary[1].ToString();
                }
                else if (count == 3)
                {
                    txtname.Text = lname[2].ToString();
                    txtage.Text = lage[2].ToString();
                    txtcon.Text = lcountry[2].ToString();
                    txtcontact.Text = lnumber[2].ToString();
                    txtdes.Text = ldesignation[2].ToString();
                    txtqua.Text = lqualification[2].ToString();
                    txtsal.Text = lsalary[2].ToString();
                }
                else
                {
                    btnbk.IsEnabled = false;
                    
                }

            }
        }
            private void Button_Click_3(object sender, RoutedEventArgs e)
            {
                count++;

                {
                    if (count == 1)
                    {
                        // MessageBox.Show(item.ToString());
                        txtname.Text = lname[0].ToString();
                        txtage.Text = lage[0].ToString();
                        txtcon.Text = lcountry[0].ToString();
                        txtcontact.Text = lnumber[0].ToString();
                        txtdes.Text = ldesignation[0].ToString();
                        txtqua.Text = lqualification[0].ToString();
                        txtsal.Text = lsalary[0].ToString();
                    }
                    else if (count == 2)
                    {
                        txtname.Text = lname[1].ToString();
                        txtage.Text = lage[1].ToString();
                        txtcon.Text = lcountry[1].ToString();
                        txtcontact.Text = lnumber[1].ToString();
                        txtdes.Text = ldesignation[1].ToString();
                        txtqua.Text = lqualification[1].ToString();
                        txtsal.Text = lsalary[1].ToString();
                    }
                    else if (count == 3)
                    {
                        txtname.Text = lname[2].ToString();
                        txtage.Text = lage[2].ToString();
                        txtcon.Text = lcountry[2].ToString();
                        txtcontact.Text = lnumber[2].ToString();
                        txtdes.Text = ldesignation[2].ToString();
                        txtqua.Text = lqualification[2].ToString();
                        txtsal.Text = lsalary[2].ToString();
                    }
                    else
                    {
                        btnfd.IsEnabled = false;
                    }

                }
            }
        }
    }




