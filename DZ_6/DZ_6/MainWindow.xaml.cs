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



namespace DZ__
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        Cleaner Tom = new Cleaner("Tom", "Black", 65.86M, 3, "O-101");
        Cleaner Bill = new Cleaner("Bill", "White", 15.12M, 4, "V-201");
        Cleaner John = new Cleaner("John", "Yellow", 55.38M, 1.2f, "V-201");

        Manager Alex = new Manager("Alex", "Blue", 115.1M, 1.5f, "V-101");
        Manager Tim = new Manager("Tim", "Gleck", 201.77M, 0.4f, "Jmih"); 
        Manager Denis = new Manager("Denis", "Petrov", 123.99M, 54f, "Jmih");

        Director Tyti = new Director("Tyti", "Ne", 1125.5M, 35f, "O-101");
        Director Tam = new Director("Tam", "Ne", 3331.4M, 4.5f, "O-101");
        Director Ching = new Director("Ching", "Chong", 2333.8M, 9.53f, "V-101");

        Programmer Jack = new Programmer("Jack", "Tall", 504.3M, 5.6f, "Jmih");
        Programmer Tyo = new Programmer("Tyo", "Nuo", 413.4M, 4f, "V-201");
        Programmer Ne = new Programmer("Ne", "Yz", 354.8M, 56f, "V-101");

        public static int count = 0;

        List<AbstractFarmerWorker> AllWorkers = new List<AbstractFarmerWorker>();

        List<AbstractFarmerWorker> CCleaners = new List<AbstractFarmerWorker>();

        List<AbstractFarmerWorker> Manageres = new List<AbstractFarmerWorker>();

        List<AbstractFarmerWorker> Programmers = new List<AbstractFarmerWorker>();

        List<AbstractFarmerWorker> Directors = new List<AbstractFarmerWorker>();

        List<string> comboItems = new List<string>();



        public MainWindow()
        {
            InitializeComponent();
            AllWorkers.Add(Tom);
            AllWorkers.Add(Bill);
            AllWorkers.Add(John);
            AllWorkers.Add(Alex);
            AllWorkers.Add(Tim);
            AllWorkers.Add(Denis);
            AllWorkers.Add(Tyti);
            AllWorkers.Add(Tam);
            AllWorkers.Add(Ching);
            AllWorkers.Add(Jack);
            AllWorkers.Add(Tyo);
            AllWorkers.Add(Ne);




            tbTest.Text = "All Patients:";
            tbTest.Text = tbTest.Text + "\n----------------";
            for (int i = 0; i < AllWorkers.Count; i++)
            {
                for (int j = 0; j < AllWorkers.Count; j++)
                {
                    if (AllWorkers[i].equals(AllWorkers[j]) && (i != j))
                    {
                        AllWorkers.RemoveAt(i);
                    }
                }
            }

            for (int i = 0; i < AllWorkers.Count; i++)
            {
                tbTest.Text = tbTest.Text + "\nWorker number: " + (i);
                tbTest.Text = tbTest.Text + "\n";
                tbTest.Text = tbTest.Text + (AllWorkers[i].info());
                tbTest.Text = tbTest.Text + "\n----------------";
                comboItems.Add(AllWorkers[i].Department);


            }
            comboItems = comboItems.Distinct().ToList();


            for (int i = 0; i < comboItems.Count; i++)
            {
                comboBox1.Items.Add(comboItems[i]);
            }



        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            decimal salary;
            float experience;
            if (TypeWorkerCombo.SelectedIndex == 0)
            {
                try
                {

                    string name = tbName.Text;
                    string surname = tbSurname.Text;
                    if (decimal.Parse(tbSalary.Text) < 0) { MessageBox.Show("Отриц данные", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error); return; }
                    else
                    {
                        salary = decimal.Parse(tbSalary.Text);
                    }
                    if (float.Parse(tbExperience.Text) < 0) { MessageBox.Show("Отриц данные", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error); return; }
                    else
                    {
                        experience = float.Parse(tbExperience.Text);
                    }
                    string department = tbDepartment.Text;
                    Director UserWorker = new Director(name, surname, salary, experience, department);
                    AllWorkers.Add(UserWorker);


                }
                catch (FormatException)
                {
                    MessageBox.Show("Что-то с данными", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            if (TypeWorkerCombo.SelectedIndex == 1)
            {
                try
                {
                    string name = tbName.Text;
                    string surname = tbSurname.Text;
                    if (decimal.Parse(tbSalary.Text) < 0) { MessageBox.Show("Отриц данные", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error); return; }
                    else
                    {
                        salary = decimal.Parse(tbSalary.Text);
                    }
                    if (float.Parse(tbExperience.Text) < 0) { MessageBox.Show("Отриц данные", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error); return; }
                    else
                    {
                        experience = float.Parse(tbExperience.Text);
                    }
                    
                    string department = tbDepartment.Text;
                    Programmer UserWorker = new Programmer(name, surname, salary, experience, department);
                    AllWorkers.Add(UserWorker);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Что-то с данными", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            if (TypeWorkerCombo.SelectedIndex == 2)
            {
                try
                {
                    string name = tbName.Text;
                    string surname = tbSurname.Text;
                    if (decimal.Parse(tbSalary.Text) < 0) { MessageBox.Show("Отриц данные", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error); return; }
                    else
                    {
                        salary = decimal.Parse(tbSalary.Text);
                    }
                    if (float.Parse(tbExperience.Text) < 0) { MessageBox.Show("Отриц данные", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error); return; }
                    else
                    {
                        experience = float.Parse(tbExperience.Text);
                    }
                   
                    string department = tbDepartment.Text;
                    Manager UserWorker = new Manager(name, surname, salary, experience, department);
                    AllWorkers.Add(UserWorker);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Что-то с данными", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            if (TypeWorkerCombo.SelectedIndex == 3)
            {
                
                try
                {
                    string name = tbName.Text;
                    string surname = tbSurname.Text;
                    if (decimal.Parse(tbSalary.Text) < 0) { MessageBox.Show("Отриц данные", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error); return; }
                    else
                    {
                        salary = decimal.Parse(tbSalary.Text);
                    }
                    if (float.Parse(tbExperience.Text) < 0) { MessageBox.Show("Отриц данные", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error); return; }
                    else
                    {
                        experience = float.Parse(tbExperience.Text);
                    }
                    
                    string department = tbDepartment.Text.ToString();
                    Cleaner UserWorker = new Cleaner(name, surname, salary, experience, department);
                    AllWorkers.Add(UserWorker);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Что-то с данными", "Проверить поля данных!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


            tbTest.Text = "All Workers:";
            tbTest.Text = tbTest.Text + "\n----------------";
            for (int i = 0; i < AllWorkers.Count; i++)
            {
                for (int j = 0; j < AllWorkers.Count; j++)
                {
                    if (AllWorkers[i].equals(AllWorkers[j]) && (i != j))
                    {
                        AllWorkers.RemoveAt(i);
                        MessageBox.Show("Одинаковые работники удалены!");
                        
                    }
                }
            }


            for (int i = 0; i < AllWorkers.Count; i++)
            {
                tbTest.Text = tbTest.Text + "\nWorker number: " + (i);
                tbTest.Text = tbTest.Text + "\n";
                tbTest.Text = tbTest.Text + (AllWorkers[i].info());
                tbTest.Text = tbTest.Text + "\n----------------";
                comboItems.Add(AllWorkers[i].Department);

            }

            comboItems = comboItems.Select(i => i).Distinct().ToList();
            comboBox1.Items.Clear();

            for (int i = 0; i < comboItems.Count; i++)
            {
                comboBox1.Items.Add(comboItems[i]);

            }
            comboBox1.SelectedIndex = 0;




        }

        private void comboBox1_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            testBox.Text = "All Workers of Department";
            
            testBox.Text = testBox.Text + "\n----------------";
            count = 0;
            decimal summa = 0;
            decimal averageSalary;
            float summa2 = 0;
            float averageExperience;
            for (int j = 0; j < AllWorkers.Count; j++)
            {

                if (Convert.ToString(comboBox1.SelectedItem) == AllWorkers[j].Department)
                {

                    testBox.Text = testBox.Text + "\n";
                    testBox.Text = testBox.Text + AllWorkers[j].info() + "\n";
                    testBox.Text = testBox.Text + "----------------";
                    summa = summa + AllWorkers[j].Salary;
                    count++;
                    averageSalary = summa / count;
                    summa2 = summa2 + AllWorkers[j].Experience;
                    averageExperience = summa2 / count;         
                    tbSalaryAver.Text = Convert.ToString(averageSalary);
                    tbExperienceAver.Text = Convert.ToString(averageExperience);                 
                }

            }
            


        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            int k = int.Parse(UserDelete.Text);
            string dep= AllWorkers[k].Department;
            
            AllWorkers.RemoveAt(k);
            for (int i = 0; i < AllWorkers.Count; i++)
            {
                if (AllWorkers[i].Department == dep)
                {
                    break;
                }
                else
                {
                    
                    comboBox1.Items.Remove(dep);
                    comboItems.Remove(dep);
                }

            }


            tbTest.Text = "";
            tbTest.Text = "All Workers:";
            tbTest.Text = tbTest.Text + "\n----------------";
            for (int i = 0; i < AllWorkers.Count; i++)
            {
                tbTest.Text = tbTest.Text + "\nWorker number: " + (i);
                tbTest.Text = tbTest.Text + "\n";
                tbTest.Text = tbTest.Text + (AllWorkers[i].info());
                tbTest.Text = tbTest.Text + "\n----------------";
                comboItems.Add(AllWorkers[i].Department);
                

            }
            comboItems = comboItems.Select(i => i).Distinct().ToList();
            comboBox1.Items.Clear();

           

            for (int i = 0; i < comboItems.Count; i++)
            {
                comboBox1.Items.Add(comboItems[i]);

            }
            



            comboBox1.SelectedIndex = 0;
        }
    }
}
