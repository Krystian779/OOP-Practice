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

namespace OOP_Practice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Event> events = new List<Event>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Create Tickets

            #region Oasis
            Ticket t1 = new Ticket("Early Bird",100m,100);
            Ticket t2 = new Ticket("Platinum", 100m, 100);
            VIPTicket t3 = new VIPTicket("Ticket and Hotel Package", 150m, 100,"4* Hotel",100m);

            List<Ticket> e1tickets = new List<Ticket>() { t1, t2, t3 };

            //Create Event

            Event e1 = new Event("Oasis Croke Park", new DateTime(2025, 6, 20), e1tickets, Event.EventType.Music);
            #endregion

            Ticket t4 = new Ticket("Friday", 100m, 100);
            Ticket t5 = new Ticket("Saturday", 100m, 100);
            Ticket t6 = new Ticket("Sunday", 100m, 100);
            Ticket t7 = new Ticket("Weekend", 200m, 100);

            VIPTicket t8 = new VIPTicket("Weekend Plus", 200m, 50, "includes camping", 100m);

            List<Ticket> e2tickets = new List<Ticket>() { t4, t5, t6, t7, t8 };

            Event e2 = new Event("Electric Picnic", new DateTime(2025, 8, 29), e2tickets, Event.EventType.Music);

            events.Add(e1);
            events.Add(e2);

            lbxEvents.ItemsSource = events;


        }

        private void lbxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            // determine which event is selected

            Event selectedEvent = lbxEvents.SelectedItem as Event;

            // check its not null
            if (selectedEvent != null)
            {
                // display tickets in the ticket listbox
                lbxTickets.ItemsSource = null;
                lbxTickets.ItemsSource = selectedEvent.Tickets;


            }


        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            // read amount required

            int numberRequired = int.Parse(tbxNumberOfTickets.Text);

            // check availibility

            Ticket selectedTicket = lbxTickets.SelectedItem as Ticket;

            // ensure not null

            if (selectedTicket != null)
            {
                int availible = selectedTicket.AvailibleTickets;

                if (availible >= numberRequired)
                {
                    // reduce number of tickets availible
                    selectedTicket.AvailibleTickets -= numberRequired;
                    MessageBox.Show($"Booking confirmed for {numberRequired} {selectedTicket.Name} tickets");

                    //refresh display
                    lbxTickets.ItemsSource = null;
                    Event selectedEvent = lbxEvents.SelectedItem as Event;

                    if (selectedEvent != null)
                    {
                        lbxTickets.ItemsSource = selectedEvent.Tickets;
                    }

                    else
                    {
                        MessageBox.Show($"Only {availible} tickets availible for {selectedTicket.Name} Please reduce number of tickets required");
                    }
                    
                }
            }

            // if availible confirm booking and reduce number of tickets availible

                // otherwise inform user ther are not enough
        }
    }
}
