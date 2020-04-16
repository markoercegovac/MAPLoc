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
using System.Collections.ObjectModel;
using WpfApp1.model;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    [Serializable]
    public partial class MainWindow : Window
    {


        private Podaci podaci = new Podaci();

        Point startPoint = new Point();//DRAG & DROP
        List<Lokali> l = new List<Lokali>();
        private IzborLokala izborLokala;
        internal Podaci Podaci { get => podaci; set => podaci = value; }

        // DRAG AND DROP
        public ObservableCollection<Lokali> Slike
        {
            get;
            set;
        }

        public ObservableCollection<Lokali> Slike2
        {
            get;
            set;
        }
        public List<Lokali> L { get => l; set => l = value; }
        public IzborLokala IzborLokala { get => izborLokala; set => izborLokala = value; }

        public MainWindow()
        {
            InitializeComponent();
            //this.DataContext = this;
            mapaLokala.ClipToBounds = true;
            Slike = new ObservableCollection<Lokali>(podaci.getLokali().Values.ToList<Lokali>());
            
            //this.panelcic.ItemsSource = Slike;
           

           
            Slike2 = new ObservableCollection<Lokali>();

        }
        

        private void close(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

       

        private void mapa(object sender, RoutedEventArgs e)
        {
            
           

        }

        private void klik(object sender, RoutedEventArgs e)
        {
            IzborLokala iz = new IzborLokala(this);
            iz.ShowDialog();
            
            
        }

        private void shutdown(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

        private void kliktip(object sender, RoutedEventArgs e)
        {
            IzborTipaLokala itl = new IzborTipaLokala();
            itl.ShowDialog();
        }
        private void kliketiketa(object sender, RoutedEventArgs e)
        {
            IzborEtikete ie = new IzborEtikete();
            ie.ShowDialog();

        }


        //drag and drop

        


        private void ListView_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent("myFormat") || sender == e.Source)
            {
                e.Effects = DragDropEffects.None;
            }
        }

        private void ListView_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            startPoint = e.GetPosition(null);
        }

        private void ListView_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(null);
            Vector diff = startPoint - mousePos;

            if (e.LeftButton == MouseButtonState.Pressed &&
                (Math.Abs(diff.X) > SystemParameters.MinimumHorizontalDragDistance ||
                Math.Abs(diff.Y) > SystemParameters.MinimumVerticalDragDistance))
            {
                // Get the dragged ListViewItem
                ListView listView = sender as ListView;
                ListViewItem listViewItem =
                    FindAncestor<ListViewItem>((DependencyObject)e.OriginalSource);
                if (listViewItem == null)
                {
                    return;
                }
                // Find the data behind the ListViewItem
               Lokali slika = (Lokali)listView.ItemContainerGenerator.
                    ItemFromContainer(listViewItem);

                // Initialize the drag & drop operation
                DataObject dragData = new DataObject("myFormat", slika);
                DragDrop.DoDragDrop(listViewItem, dragData, DragDropEffects.Move);
            }

            
        }
        public T FindAncestor<T>(DependencyObject current) where T : DependencyObject
        {
            do
            {
                if (current is T)
                {
                    return (T)current;
                }
                current = VisualTreeHelper.GetParent(current);
            }
            while (current != null);
            return null;
        }

        private void ListView_Drop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("myFormat"))
            {
                Lokali student = e.Data.GetData("myFormat") as Lokali;
                
                Slike2.Add(student);

                Point current_position = e.GetPosition(mapaLokala);
                Rect curr_rect = new Rect(current_position, new Size(50, 50));
                Rect map_rect = new Rect(new Size(mapaLokala.ActualWidth,mapaLokala.ActualHeight));

                foreach (Rect r in podaci.vratiSlike().Values)
                {
                    if (r.IntersectsWith(curr_rect))
                    {
                        System.Windows.MessageBox.Show("Slike ne smeju da se preklapaju");
                        return;
                    }
                             
                }
                if (current_position.X > mapaLokala.ActualWidth-25|| current_position.Y>mapaLokala.ActualHeight-25||current_position.X<25||current_position.Y<25)
                {
                    System.Windows.MessageBox.Show("Slika mora biti dodata u okviru mape, a ne van nje!! ");
                    return;
                }

                if (podaci.vratiSlike().ContainsKey(student.Id))
                {
                    System.Windows.MessageBox.Show("Slika sa tim id vec postoji na mapi, molim vas da uklonite trenutnu sliku sa mape, pa tek onda dodate novu sliku.");
                    return;
                }

                podaci.vratiSlike().Add(student.Id, curr_rect);
                //Slike.Remove(student);

                Image img = new Image();
                img.Width = 50;
                img.Height = 50;
                img.Source = new BitmapImage(new Uri(student.Image2));
                img.ToolTip += "Naziv lokala:";
                img.ToolTip += student.Naziv+"\n";
                img.ToolTip += "Id lokala:";
                img.ToolTip += student.Id;

                ContextMenu contextMenu = new ContextMenu();
                
                //MenuItem item = new MenuItem();
                //MenuItem item2 = new MenuItem();
                MenuItem item3 = new MenuItem();
               
                item3.Header = "Izbrisi";
                Rect rectangle = new Rect();
                rectangle.Size = new Size(50, 50);


                item3.Click += delegate { mapaLokala.Children.Remove(img); };
                item3.Click += delegate { Podaci.brisanjeSlike(student.Id); };
                //item2.Click += delegate
                {
                    /*EditLokali ed = new EditLokali();
                    ed.InitializeComponent();
                    ed.idTxt.Text = podaci.getLokali()[student.Id].Id;
                    ed.nazivTxt.Text = podaci.getLokali()[student.Id].Naziv;
                    ed.opisTxt.Text = podaci.getLokali()[student.Id].Opis;
                    ed.tipCombo.Items.Add(podaci.getLokali()[student.Id].Tip);
                    foreach(String str in podaci.getLokali()[student.Id].Etikete)
                    {
                        ed.etiketeCombo.Items.Add(str);
                    }
                    ed.pusenjeCombo.Text = podaci.getLokali()[student.Id].Pusenje;
                    ed.slikaLokala.Source = new BitmapImage(new Uri( podaci.getLokali()[student.Id].Image2));
                    ed.alkoholCombo.Text = podaci.getLokali()[student.Id].Alkohol;
                   
                    ed.ShowDialog();
                    */
                };
                //contextMenu.Items.Add(item);
                //contextMenu.Items.Add(item2);
                contextMenu.Items.Add(item3);
                img.ContextMenu = contextMenu;



                Point p = e.GetPosition(mapaLokala);
                Canvas.SetTop(img, p.Y-25);
                Canvas.SetLeft(img, p.X-25);





                mapaLokala.Children.Add(img);

            }

        }
        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            IInputElement focusedControl = FocusManager.GetFocusedElement(Application.Current.Windows[0]);
            if (focusedControl is DependencyObject)
            {
                string str = HelpProvider.GetHelpKey((DependencyObject)focusedControl);
                HelpProvider.ShowHelp(str);
            }
        }

    }
}