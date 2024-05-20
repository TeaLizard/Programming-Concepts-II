namespace AirTicketAssignment
{
    using System.Text.RegularExpressions;
    public partial class Form1 : Form
    {
        const int NumRows = 13; // Number of seat rows
        const int SeatsPerRow = 4; // Number of seats per row (seat columns)
        const int MaxSizeOfWaitingList = 10; // The maximum number of passengers allowed on the WaitList
        const string Flight = "CON568"; // Flight identifier (not used)
        private Passenger[,] Reservations = new Passenger[NumRows, SeatsPerRow]; // A 13x4 2 dimensional array that holds passengers who have seats reserved
        private Button[,] Seats = new Button[NumRows, SeatsPerRow];  // A 13x4 2 dimensional array that holds the information of every seat Button
        private static int ReservationCounterEconomy = 40, ReservationCounterBusiness = 12; // Available seats on the plane, for both economy and business
        private List<Passenger> WaitList = new(MaxSizeOfWaitingList); // List of passengers on the WaitList
        private static int WaitListCounter = 0; // Counter used to count the number of people in the WaitList
        private static bool SeatIsHovered = false; // Boolean used for ToolTip redundancy 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // Initializing all of the seats into a 13x4 array
        {
            Seats[0, 0] = SeatA1;
            Seats[1, 0] = SeatA2;
            Seats[2, 0] = SeatA3;
            Seats[3, 0] = SeatA4;
            Seats[4, 0] = SeatA5;
            Seats[5, 0] = SeatA6;
            Seats[6, 0] = SeatA7;
            Seats[7, 0] = SeatA8;
            Seats[8, 0] = SeatA9;
            Seats[9, 0] = SeatA10;
            Seats[10, 0] = SeatA11;
            Seats[11, 0] = SeatA12;
            Seats[12, 0] = SeatA13;

            Seats[0, 1] = SeatB1;
            Seats[1, 1] = SeatB2;
            Seats[2, 1] = SeatB3;
            Seats[3, 1] = SeatB4;
            Seats[4, 1] = SeatB5;
            Seats[5, 1] = SeatB6;
            Seats[6, 1] = SeatB7;
            Seats[7, 1] = SeatB8;
            Seats[8, 1] = SeatB9;
            Seats[9, 1] = SeatB10;
            Seats[10, 1] = SeatB11;
            Seats[11, 1] = SeatB12;
            Seats[12, 1] = SeatB13;

            Seats[0, 2] = SeatC1;
            Seats[1, 2] = SeatC2;
            Seats[2, 2] = SeatC3;
            Seats[3, 2] = SeatC4;
            Seats[4, 2] = SeatC5;
            Seats[5, 2] = SeatC6;
            Seats[6, 2] = SeatC7;
            Seats[7, 2] = SeatC8;
            Seats[8, 2] = SeatC9;
            Seats[9, 2] = SeatC10;
            Seats[10, 2] = SeatC11;
            Seats[11, 2] = SeatC12;
            Seats[12, 2] = SeatC13;

            Seats[0, 3] = SeatD1;
            Seats[1, 3] = SeatD2;
            Seats[2, 3] = SeatD3;
            Seats[3, 3] = SeatD4;
            Seats[4, 3] = SeatD5;
            Seats[5, 3] = SeatD6;
            Seats[6, 3] = SeatD7;
            Seats[7, 3] = SeatD8;
            Seats[8, 3] = SeatD9;
            Seats[9, 3] = SeatD10;
            Seats[10, 3] = SeatD11;
            Seats[11, 3] = SeatD12;
            Seats[12, 3] = SeatD13;
        }

        private void SeatClick(object sender, EventArgs e) // Clicking a seat will fill the seat boxes with the seat id
        {
            Button buttonInput = (Button)sender;

            ReserveSeatBox.Text = buttonInput.Tag.ToString();
            StatusSeatBox.Text = buttonInput.Tag.ToString();
            CancelSeatBox.Text = buttonInput.Tag.ToString();
        }

        private void ValidatePassenger(string firstName, string lastName, string phoneNumberString, string eMail, string seat, bool reservation) // Validates passenger information and creates an instance of that passenger. It adds the passenger to either the reservation or the waitlist.
        {
            int seatRow = -1, seatCol = -1; // Initializing variables for the row and column of the seat;
            Int64 phoneNumber; // Initializing the phone number
            if (reservation) // Check seat if reservation selected
            {
                if (ValidateSeat(seat, out seatRow, out seatCol) == false) // return if seat is invalid
                {
                    return;
                }
            }

            if (string.IsNullOrEmpty(firstName.Trim())) // Invalid empty name
            {
                MessagesBox.Text = "First name cannot be empty";
                return;
            }

            if (string.IsNullOrEmpty(lastName.Trim())) // Invalid empty name
            {
                MessagesBox.Text = "Last name cannot be empty";
                return;
            }

            Regex phoneNumberFormat = new(@"^\d\d\d-?\d\d\d-?\d\d\d\d$"); // Accepts phone number with or without dashes
            if (phoneNumberString.Trim().Length == 10 && phoneNumberFormat.IsMatch(phoneNumberString)) // If no dashes and valid, set phone number
            {
                phoneNumber = Int64.Parse(phoneNumberString.Trim());
            }
            else if (phoneNumberString.Trim().Length == 12)
            {
                if (phoneNumberFormat.IsMatch(phoneNumberString.Trim())) // If with dashes, and valid, remove dashes and set number
                {
                    string sub1, sub2, sub3;
                    sub1 = phoneNumberString.Substring(0, 3);
                    sub2 = phoneNumberString.Substring(4, 3);
                    sub3 = phoneNumberString.Substring(8, 4);
                    phoneNumber = Int64.Parse(sub1 + sub2 + sub3);
                }
                else // Phone number string does not match regex
                {
                    MessagesBox.Text = "Invalid phone number";
                    return;
                }
            }
            else // Phone number string does not match regex
            {
                MessagesBox.Text = "Invalid phone number";
                return;
            }


            Regex emailFormat = new(@"^[a-z0-9~!$%^&*_=+}{'?\-.]{1,20}@[a-z0-9.]{1,20}\.[a-z]{2,3}$"); // Email verification (Captitals are ToLower()'d before this is used)
            if (emailFormat.IsMatch(eMail.Trim().ToLower()) == false) // Invalid email format
            {
                MessagesBox.Text = "Invalid email";
                return;
            }

            // Old email verification

            //if (eMail.Contains("@") && eMail.Contains(".")) // Email Verification
            //{
            //    if (eMail.IndexOf("@") < eMail.IndexOf(".")) // "@" before "."
            //    {
            //        if (eMail.IndexOf("@") == eMail.LastIndexOf("@")) // Code to check for more than one "@"
            //        {
            //            // Valid Email
            //        }
            //        else
            //        {
            //            MessagesBox.Text = "Invalid Email Address";
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        MessagesBox.Text = "Invalid Email Address";
            //        return;
            //    }
            //}
            //else
            //{
            //    MessagesBox.Text = "Invalid Email Address";
            //    return;
            //}


            if (reservation) // Add to reservation
            {
                if (Reservations[seatRow, seatCol] == null) // Add if the seat is empty
                {
                    Passenger passenger = new(firstName.Trim(), lastName.Trim(), phoneNumber, eMail.Trim().ToLower(), seat.Trim()); // Create Passenger
                    Reservations[seatRow, seatCol] = passenger;
                    //Seats[,] = 
                    ReservationListBox.Items.Add(passenger.ToString("seat"));

                    // Changes the seat colour and text, checks if the seat is business or economy by the seat row.
                    if (seatRow <= 2) // Buisiness class
                    {
                        ReservationSeatChange(true, true, seat);
                    }
                    else // Economy
                    {
                        ReservationSeatChange(true, false, seat);
                    }
                }
                else // Seat cannot be reserved twice
                {
                    MessagesBox.Text = "Seat already in use";
                    return;
                }
            }
            else // Add to wait list
            {
                if (++WaitListCounter <= MaxSizeOfWaitingList) // Counts the waitlist until there are 10 passengers waiting and the list is full
                {
                    Passenger passenger = new(firstName.Trim(), lastName.Trim(), phoneNumber, eMail.Trim().ToLower()); // Create Passenger
                    WaitList.Add(passenger); // Add the passenger to the waitlist
                    WaitListBox.Items.Add(passenger.ToString());
                    WaitListLabel.Text = $"On waiting list: {WaitListCounter}"; // Update the label displaying number of people on the waitlist
                }
                else // Cannot add more than 10 people to the waitlist
                {
                    MessagesBox.Text = "Wait list can only hold 10 members";
                    return;
                }
            }
        }

        private bool ValidateSeat(string seat, out int seatRow, out int seatCol) // Output seat row and column, returns true or false if seat is valid or not
        {
            seat = seat.ToUpper(); // Seats look for capital letters
            seatRow = -1; seatCol = -1; // These have to have a value before the first return statement

            if (seat.Trim().Length == 2 || seat.Trim().Length == 3) // Checks for right seat size
            {
                if (int.TryParse(seat.Trim().Substring(1), out seatRow)) // TryParse the seat row (index)
                {
                    seatRow--; // -1 to get the index
                    if (seatRow < 0 || seatRow > 13) // seat row is out of range
                    {
                        MessagesBox.Text = "Invalid seat!";
                        return false;
                    }
                }
                else // Failed Parse
                {
                    MessagesBox.Text = "Invalid seat!";
                    return false;
                }
            }
            else // Incorrect size of seat string
            {
                MessagesBox.Text = "Invalid seat!";
                return false;
            }

            switch (seat.Substring(0, 1)) // Case statement for seat column (index)
            {
                case "A":
                    seatCol = 0;
                    break;
                case "B":
                    seatCol = 1;
                    break;
                case "C":
                    seatCol = 2;
                    break;
                case "D":
                    seatCol = 3;
                    break;
                default:
                    MessagesBox.Text = "Invalid seat!"; // Invalid if not A, B, C, or D.
                    return false;
            }
            return true; // Return true if false is never returned
        }

        private void SeatHover(object sender, EventArgs e) // Hovering over a seat makes it display "Available" or the name of the passenger in that seat .I had trouble getting this to work origionally so there are redundant properties.
        {
            if (SeatIsHovered == false) // Cannot trip twice until the cursor is no longer hovered (SeatUnhover())
            {
                SeatIsHovered = true; // Cannot trip twice until the cursor is no longer hovered (SeatUnhover())
                Button buttonInput = (Button)sender;

                bool seatIsAvailable = true; // Used for the if statement, if a passenger is not found in the foreach loop
                foreach (Passenger passenger in Reservations) // Check every passenger
                {
                    if (passenger == null) continue;
                    else if (passenger.Seat == buttonInput.Tag.ToString()) // If seat is taken, display passenger name
                    {
                        ToolTip_.SetToolTip(buttonInput, passenger.GetName());
                        seatIsAvailable = false;
                        break;
                    }
                }
                if (seatIsAvailable && buttonInput.BackColor != Color.Red) // If seat is not taken by any passengers, display "Available"
                {
                    ToolTip_.SetToolTip(buttonInput, "Available");
                }
            }
        }

        private void SeatUnhover(object sender, EventArgs e) // When the cursor leaves a seat button, the SeatHover() can be used again.
        {
            SeatIsHovered = false;
        }

        private void ButtonClick(object sender, EventArgs e) // Controls for all of the non-seat buttons
        {
            Button buttonInput = (Button)sender;

            switch (buttonInput.Text)
            {
                case "Reset": // Resets all of the textboxes except for the "flight" boxes when the "Reset" button is clicked
                    ReserveSeatBox.Text = "";
                    StatusSeatBox.Text = "";
                    CancelSeatBox.Text = "";
                    FirstNameBox.Text = "";
                    LastNameBox.Text = "";
                    PhoneNumberBox.Text = "";
                    EmailBox.Text = "";
                    MessagesBox.Text = "";
                    break;

                case "Add To Waiting List": // Validates and adds passenger to waitlist when the "Add To Waiting List" button is clicked
                    ValidatePassenger(FirstNameBox.Text, LastNameBox.Text, PhoneNumberBox.Text, EmailBox.Text, ReserveSeatBox.Text, false);
                    break;

                case "Reserve Seat": // Validates and adds passenger to Reservations when the "Reserve Seat" button is clicked
                    ValidatePassenger(FirstNameBox.Text, LastNameBox.Text, PhoneNumberBox.Text, EmailBox.Text, ReserveSeatBox.Text, true);
                    break;

                case "Cancel": // Removes the passenger from the seat typed in the cancel seat box, or sends error message about invalid or empty seat.
                    bool passengerFound = false; // Tracks if a passenger is found in the foreach loop
                    foreach (Passenger passenger in Reservations)
                    {
                        if (passenger == null) continue;
                        else if (passenger.Seat == CancelSeatBox.Text.Trim()) // Passenger found
                        {
                            ValidateSeat(CancelSeatBox.Text.Trim(), out int seatRow, out int seatCol); // Gets seat row and column from the cancel seat textbox
                            passengerFound = true;
                            Reservations[seatRow, seatCol] = null; // Remove passenger from the Reservations array
                            ReservationListBox.Items.Remove(passenger.ToString("seat")); // Remove passenger from the dropdown list

                            // Changes the color and text of the selected seat, finds if it is business or economy by the seat row
                            if (seatRow <= 2) // Buisiness class
                            {
                                ReservationSeatChange(false, true, passenger.Seat);
                            }
                            else // Economy
                            {
                                ReservationSeatChange(false, false, passenger.Seat);
                            }
                            return;
                        }
                    }
                    if (passengerFound == false) //  If the passenger is not found then the seat is empty or invalid
                    {
                        if (ValidateSeat(CancelSeatBox.Text.Trim(), out _, out _)) // If the seat exists, display that the seat is empty
                        {
                            MessagesBox.Text = $"There is no passenger in seat {CancelSeatBox.Text.Trim()}";
                            return;
                        }
                        else // If the seat does not exist, display that the seat does not exist
                        {
                            MessagesBox.Text = "Invalid seat";
                            return;
                        }
                    }
                    break;

                case "Status": // Displays the status of a passenger, if the seat is open, or if an invalid seat was entered.
                    passengerFound = false; // Tracks if a passenger is found in the foreach loop
                    foreach (Passenger passenger in Reservations)
                    {
                        if (passenger == null) continue;
                        else if (passenger.Seat == StatusSeatBox.Text.Trim()) // Passenger found
                        {
                            MessagesBox.Text = passenger.ToString("seat"); // Display the passenger info
                            passengerFound = true;
                            return;
                        }
                    }
                    if (passengerFound == false) // Passenger not found
                    {
                        if (ValidateSeat(StatusSeatBox.Text.Trim(), out int seatRow, out int seatCol)) // Valid empty seat
                        {
                            MessagesBox.Text = $"Seat {StatusSeatBox.Text.Trim()} is available!";
                            return;
                        }
                        else // Invalid seat
                        {
                            MessagesBox.Text = "Invalid seat!";
                            return;
                        }
                    }
                    break;

                // Finish Later!
                case "Reset All": // Resets everything
                    ReserveSeatBox.Text = "";
                    StatusSeatBox.Text = "";
                    CancelSeatBox.Text = "";
                    FirstNameBox.Text = "";
                    LastNameBox.Text = "";
                    PhoneNumberBox.Text = "";
                    EmailBox.Text = "";
                    Reservations = new Passenger[NumRows, SeatsPerRow];
                    WaitList = new List<Passenger>(MaxSizeOfWaitingList);
                    WaitListCounter = 0;
                    ReservationCounterEconomy = 40;
                    ReservationCounterBusiness = 12;
                    ReservationListBox.Items.Clear();
                    WaitListBox.Items.Clear();
                    MessagesBox.Text = "";
                    foreach (Button button in Seats) // Resets the seat colours and prices
                    {
                        ValidateSeat(button.Tag.ToString(), out int seatRow, out _);
                        if (seatRow <= 2)
                        {
                            button.BackColor = Color.Yellow;
                            button.Text = "$450";
                        }
                        else
                        {
                            button.BackColor = Color.Lime;
                            button.Text = "$200";
                        }
                    }
                    return;
            }
        }

        private void ReservationSeatChange(bool reservationAdd, bool isBusiness, string seat) // This method deals with the seat background colors and dynamic pricing. It has 4 sections: adding buisiness, adding economy, removing business, and removing economy.
        {
            if (reservationAdd) // Add passenger to seat
            {
                if (isBusiness) // Add business
                {
                    ReservationCounterBusiness--; // Decrement number of available business seats
                    double reservationCounterBusiness = Convert.ToDouble(ReservationCounterBusiness);
                    double reservationCounterEconomy = Convert.ToDouble(ReservationCounterEconomy);
                    double percentageDouble = ((reservationCounterBusiness + reservationCounterEconomy) / 52d) * 100d;
                    int percentage = Convert.ToInt32(percentageDouble); // Do math for percentage in double and convert back to int
                    SeatsAvailableLabel.Text = $"Seats available: {52 - (ReservationCounterBusiness + ReservationCounterEconomy)} ({percentage}%)"; // Display available seats and the percentage of available seats
                    double price = 450d + (120d / Convert.ToDouble(ReservationCounterBusiness)); // Do math for dynamic seat pricing
                    foreach (Button button in Seats)
                    {
                        ValidateSeat(button.Tag.ToString(), out int seatRow, out _); // Get seat row for each seat
                        if (seatRow <= 2 && button.BackColor != Color.Red) // Uses seat row to find business seats, and checks that the background colour is not red (Red seats don't display text)
                        {
                            button.Text = $"{Convert.ToInt32(price).ToString()}$";
                        }
                        if (button.Tag.ToString() == seat) // Sets the reserved seat to Red and clears the text
                        {
                            button.BackColor = Color.Red;
                            button.Text = "";
                        }
                    }

                }
                else // Add ecomomy
                {
                    ReservationCounterEconomy--; // Decrement number of available economy seats
                    double reservationCounterBusiness = Convert.ToDouble(ReservationCounterBusiness);
                    double reservationCounterEconomy = Convert.ToDouble(ReservationCounterEconomy);
                    double percentageDouble = ((reservationCounterBusiness + reservationCounterEconomy) / 52d) * 100d;
                    int percentage = Convert.ToInt32(percentageDouble); ; // Do math for percentage in double and convert back to int
                    SeatsAvailableLabel.Text = $"Seats available: {52 - (ReservationCounterBusiness + ReservationCounterEconomy)} ({percentage}%)"; // Display available seats and the percentage of available seats
                    double price = 200d + (60d / Convert.ToDouble(ReservationCounterEconomy)); // Do math for dynamic seat pricing
                    foreach (Button button in Seats)
                    {
                        ValidateSeat(button.Tag.ToString(), out int seatRow, out _); // Get seat row for each seat
                        if (seatRow >= 3 && button.BackColor != Color.Red) // Uses seat row to find economy seats, and checks that the background colour is not red (Red seats don't display text)
                        {
                            button.Text = $"{Convert.ToInt32(price).ToString()}$";
                        }
                        if (button.Tag.ToString() == seat) // Sets the reserved seat to Red and clears the text
                        {
                            button.BackColor = Color.Red;
                            button.Text = "";
                        }
                    }
                }
            }
            else // Remove passenger from seat (first seats are not dynamic, like the documents say, though it should always be dynamic)
            {
                if (isBusiness) // Remove business
                {
                    ReservationCounterBusiness++; // Increment number of available business seats
                    double reservationCounterBusiness = Convert.ToDouble(ReservationCounterBusiness);
                    double reservationCounterEconomy = Convert.ToDouble(ReservationCounterEconomy);
                    double percentageDouble = ((reservationCounterBusiness + reservationCounterEconomy) / 52d) * 100d;
                    int percentage = Convert.ToInt32(percentageDouble); // Do math for percentage in double and convert back to int
                    SeatsAvailableLabel.Text = $"Seats available: {52 - (ReservationCounterBusiness + ReservationCounterEconomy)} ({percentage}%)"; // Display available seats and the percentage of available seats
                    if (ReservationCounterBusiness == 12) // Remove from last seat
                    {
                        double price = 450d;
                        foreach (Button button in Seats)
                        {
                            ValidateSeat(button.Tag.ToString(), out int seatRow, out _); // Get seat row for each seat
                            if (seatRow <= 2 && button.BackColor != Color.Red) // Uses seat row to find business seats, and checks that the background colour is not red (Red seats don't display text)
                            {
                                button.Text = $"{Convert.ToInt32(price).ToString()}$"; 
                            }
                            if (button.Tag.ToString() == seat) // Sets the unreserved seat to Yellow and updates the price
                            {
                                button.BackColor = Color.Yellow;
                                button.Text = $"{Convert.ToInt32(price).ToString()}$";
                            }
                        }
                    }
                    else
                    {
                        double price = 450d + (120d / Convert.ToDouble(ReservationCounterBusiness)); // Do math for dynamic seat pricing
                        foreach (Button button in Seats)
                        {
                            ValidateSeat(button.Tag.ToString(), out int seatRow, out _); // Get seat row for each seat
                            if (seatRow <= 2 && button.BackColor != Color.Red) // Uses seat row to find business seats, and checks that the background colour is not red (Red seats don't display text)
                            {
                                button.Text = $"{Convert.ToInt32(price).ToString()}$";
                            }
                            if (button.Tag.ToString() == seat) // Sets the unreserved seat to Yellow and updates the price
                            {
                                button.BackColor = Color.Yellow;
                                button.Text = $"{Convert.ToInt32(price).ToString()}$";

                            }
                        }
                    }
                }
                else // Remove economy
                {
                    ReservationCounterEconomy++; // Increment number of available economy seats
                    double reservationCounterBusiness = Convert.ToDouble(ReservationCounterBusiness);
                    double reservationCounterEconomy = Convert.ToDouble(ReservationCounterEconomy);
                    double percentageDouble = ((reservationCounterBusiness + reservationCounterEconomy) / 52d) * 100d;
                    int percentage = Convert.ToInt32(percentageDouble); // Do math for percentage in double and convert back to int
                    SeatsAvailableLabel.Text = $"Seats available: {52 - (ReservationCounterBusiness + ReservationCounterEconomy)} ({percentage}%)"; // Display available seats and the percentage of available seats
                    if (ReservationCounterEconomy == 40) // Remove from last seat
                    {
                        double price = 200d;
                        foreach (Button button in Seats)
                        {
                            ValidateSeat(button.Tag.ToString(), out int seatRow, out _); // Get seat row for each seat
                            if (seatRow >= 3 && button.BackColor != Color.Red) // Uses seat row to find business seats, and checks that the background colour is not red (Red seats don't display text)
                            {
                                button.Text = $"{Convert.ToInt32(price).ToString()}$";
                            }
                            if (button.Tag.ToString() == seat) // Sets the unreserved seat to Lime and updates the price
                            {
                                button.BackColor = Color.Lime;
                                button.Text = $"{Convert.ToInt32(price).ToString()}$";
                            }
                        }
                    }
                    else
                    {
                        double price = 200d + (60d / Convert.ToDouble(ReservationCounterEconomy)); // Do math for dynamic seat pricing
                        foreach (Button button in Seats)
                        {
                            ValidateSeat(button.Tag.ToString(), out int seatRow, out _); // Get seat row for each seat
                            if (seatRow >= 3 && button.BackColor != Color.Red) // Uses seat row to find business seats, and checks that the background colour is not red (Red seats don't display text)
                            {
                                button.Text = $"{Convert.ToInt32(price).ToString()}$";
                            }
                            if (button.Tag.ToString() == seat) // Sets the unreserved seat to Lime and updates the price
                            {
                                button.BackColor = Color.Lime;
                                button.Text = $"{Convert.ToInt32(price).ToString()}$";
                            }
                        }
                    }
                }
            }
        }
    }
}