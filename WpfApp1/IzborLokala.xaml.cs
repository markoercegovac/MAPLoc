using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for IzborLokala.xaml
    /// </summary>
    /// 

    public partial class IzborLokala : Window
    {
        private MainWindow mainWindow;

        public MainWindow MainWindow { get => mainWindow; set => mainWindow = value; }

        public IzborLokala()
        {


            InitializeComponent();
           
           
            
            
        }

        public IzborLokala(MainWindow mainWindow)
        {

            InitializeComponent();
            foreach(KeyValuePair<string,Lokali> entry in mainWindow.Podaci.getLokali())
            {
                comboBox.Items.Add(entry.Key);
            }
            
            this.MainWindow = mainWindow;
        }

        private void klik1(object sender, RoutedEventArgs e)
        {
            Forma fm = new Forma(this);
              


            fm.ShowDialog();
        }

        private void klik2(object sender, RoutedEventArgs e)
        {
            if (comboBox.SelectedIndex==-1)
            {
                return;
            }
            EditLokali ed = new EditLokali(this);
            ed.ShowDialog();
        }

        //promena boje za dugme dodavnja
        private void dugme3(object sender, System.Windows.Input.MouseEventArgs e)
        {
            buttonDodaj.Foreground = Brushes.Black;
        }
        private void dugme4(object sender, System.Windows.Input.MouseEventArgs e)
        {
            buttonDodaj.Foreground = Brushes.White;
        }


        //promena boje za dugme izmene
        private void dugme5(object sender, System.Windows.Input.MouseEventArgs e)
        {
            buttonIzmeni.Foreground = Brushes.Black;
        }
        private void dugme6(object sender, System.Windows.Input.MouseEventArgs e)
        {
            buttonIzmeni.Foreground = Brushes.White;
        }

        private void brisanje(object sender, RoutedEventArgs e)
        {
            string textzaBrisanje = comboBox.Text;
            foreach(KeyValuePair<string,Lokali> entry in mainWindow.Podaci.getLokali())
            {
                if (entry.Value.Id == textzaBrisanje)
                {
                    
                }
            }
            MainWindow.Podaci.ukloniLokal(textzaBrisanje);
            comboBox.Items.Remove(textzaBrisanje);

            mainWindow.Slike = new System.Collections.ObjectModel.ObservableCollection<Lokali>(mainWindow.Podaci.getLokali().Values.ToList<Lokali>());
            mainWindow.panelcic.ItemsSource = null;
            mainWindow.panelcic.ItemsSource = mainWindow.Slike;
            //forma.IzborLokala.MainWindow.panelcic.ItemsSource = null;
            //forma.IzborLokala.MainWindow.panelcic.ItemsSource = forma.IzborLokala.MainWindow.Slike;

            this.Close();
        }
        private void tabela(object sender, RoutedEventArgs e)
        {
            TabelaLokali tabela = new TabelaLokali(this);
            tabela.Show();
        }

        private void cuvaj(object sender, RoutedEventArgs e)
        {
            
            SaveFileDialog dlg = new SaveFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                BinaryFormatter bFormater = new BinaryFormatter();
                FileStream stream=null;
                try
                {
                    stream = File.Open(dlg.FileName, FileMode.OpenOrCreate);
                    
            
                    bFormater.Serialize(stream, mainWindow.Podaci);


                }
                catch (SerializationException ee)
                {
                    Console.Write(ee.Message);
                    throw;
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Dispose();
                    }
                }
               

            }
            
        }
        private void load(object sender,RoutedEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            this.Close();

            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {/*
                Stream stream = File.Open(dlg.FileName, FileMode.Open);
                mainWindow.Podaci = (Podaci)formatter.Deserialize(stream);
                stream.Close();*/
                BinaryFormatter bFormater = new BinaryFormatter();
                FileStream stream = null;
                Podaci retval = null;
                try
                {
                    stream = File.Open(dlg.FileName, FileMode.Open);
                    retval = (Podaci)bFormater.Deserialize(stream);

                }
                catch (SerializationException ee)
                {
                    Console.Write(ee.Message);
                    throw;
                }
                finally
                {
                    if (stream != null)
                    {
                        stream.Dispose();
                        mainWindow.Podaci = retval;
                       
                        mainWindow.mapaLokala.Children.Clear();
                        mainWindow.Slike = new System.Collections.ObjectModel.ObservableCollection<Lokali>(MainWindow.Podaci.getLokali().Values.ToList<Lokali>());
                        MainWindow.panelcic.ItemsSource = null;

                        mainWindow.panelcic.ItemsSource = mainWindow.Slike;
                        mainWindow.panelcic.Items.Refresh();

                        foreach(String str in mainWindow.Podaci.vratiSlike().Keys)
                        {
                            Image img = new Image();
                            img.Source = new BitmapImage(new Uri(mainWindow.Podaci.getLokali()[str].Image2));
                            //img.ToolTip = student.Id;
                            img.ToolTip += "Naziv lokala:";
                            img.ToolTip += mainWindow.Podaci.getLokali()[str].Naziv + "\n";
                            img.ToolTip += "Id lokala:";
                            img.ToolTip += mainWindow.Podaci.getLokali()[str].Id;
                            System.Windows.Controls.ContextMenu contextMenu = new System.Windows.Controls.ContextMenu();

                            //System.Windows.Controls.MenuItem item = new System.Windows.Controls.MenuItem();
                            //System.Windows.Controls.MenuItem item2 = new System.Windows.Controls.MenuItem();
                            System.Windows.Controls.MenuItem item3 = new System.Windows.Controls.MenuItem();
                           
                            item3.Header = "Izbrisi";

                            
                            contextMenu.Items.Add(item3);
                            img.ContextMenu = contextMenu;

                            img.Height = 50;
                            img.Width = 50;
                            item3.Click += delegate { mainWindow.mapaLokala.Children.Remove(img); };
                            item3.Click += delegate { mainWindow.Podaci.brisanjeSlike(str); };


                            Canvas.SetTop(img, mainWindow.Podaci.vratiSlike()[str].Y);
                            Canvas.SetLeft(img, mainWindow.Podaci.vratiSlike()[str].X);

                            mainWindow.mapaLokala.Children.Add(img);

                        }
                        

                    }
                }

            }
            
        }

        private void CommandBinding_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            this.cuvaj(sender, e);
        }

        private void CommandBinding_Executed_1(object sender, ExecutedRoutedEventArgs e)
        {

        }
        private void CommandBinding_Executed2(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(System.Windows.Application.Current.Windows[0]);
            if (focusedControl is DependencyObject)
            {
                string str = model.HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                model.HelpProvider.ShowHelp(str);
            }
        }
    }
}
