using mis_221_pa_5_hmmularz;
  TrainerUtility.ReadInTrainers();
ListingUtility.ReadInListings();


 MainMenu(); 
 TrainerUtility.WriteOutTrainers();
ListingUtility.WriteOutListings();

static void MainMenu(){
    string userInput = ""; 

Console.WriteLine("Hello! Please select an option: 1 to manage trainer data, 2 to manage listing data, 3 to manage customer booking data, 4 to run reports, and 5 to exit.");
userInput = Console.ReadLine();

if(userInput == "1"){
    TrainerFunctions(); //go to the trainer functions method 


}

else if  (userInput == "2"){
    ListingFunctions(); //go to method for listing functions 
}

else if (userInput =="3"){
    BookingFunctions(); //go to method for booking functions 
}
 
else if(userInput == "4"){
    ReportFunctions(); //go to method for report functions 

}

else if(userInput == "5"){
    ExitProgram(); //go to method for exiting the program 

}

else {
    Console.WriteLine("Invalid option! Please make another selection");
    Console.WriteLine("Hello! Please select an option: 1 to manage trainer data, 2 to manage listing data, 3 to managae customer booking data, 4 to run reports, and 5 to exit.");
    userInput = Console.ReadLine(); // update read 
}

}


 static void TrainerFunctions(){
    Console.WriteLine("Welcome to trainer functions! Enter 1 if you want to add information, 2 if you want to edit/delete information, or 3 to go back to the main menu.");
    string userInput = Console.ReadLine(); //read in the user's input 
    if(userInput == "1" ){
        AddATrainer();
    }
    else if(userInput == "2"){
        EditTrainer();
    }
    
    else if(userInput == "3"){
       MainMenu(); 
    }
    else{
        Console.WriteLine("Invalid option! Please enter a differet option");
        Console.WriteLine("Welcome to trainer functions! Enter 1 if you want to add information, 2 if you want to edit/delete information, or 3 to go back to the main menu.");
        userInput = Console.ReadLine(); //update read 
    }
}

 static void AddATrainer(){ //method to add a trainer 
    
     
    Console.WriteLine("What is the trainer's name?");
    string trainerName = Console.ReadLine();
    Console.WriteLine("What is the trainer's address?");
    string trainerAddress = Console.ReadLine();
    Console.WriteLine("What is the trainer's email?");
    string trainerEmail = Console.ReadLine();

    Trainer[] allTrainers = TrainerUtility.GetAllTrainers(); 
    int allTrainersCount = TrainerUtility.GetCount(); 
    Trainer newTrainer = new Trainer(allTrainersCount, trainerName, trainerAddress, trainerEmail, false);

    allTrainers[allTrainersCount] = newTrainer; 
    TrainerUtility.IncCount();
    TrainerUtility.SetAllTrainers(allTrainers); 
    TrainerUtility.WriteOutTrainers(); 
    MainMenu(); //go back to main menu at the end 


}

 static void EditTrainer(){ //method to edit a trainer 
    TrainerUtility.DisplayAllTrainers(); 
    Console.WriteLine("Enter the trainer ID for the trainer you would like to edit.");
    int editingID = int.Parse(Console.ReadLine()); 
    Console.WriteLine("What would you like to edit. Enter 1 to edit the name, 2 to edit mailing address, 3 to edit email address or 4 to delete"); 
    string userInput = Console.ReadLine(); 
    Trainer[] alltrainers = TrainerUtility.GetAllTrainers(); 
    switch (userInput)
    {
        case "1": 
        Console.WriteLine("What would you like the name to be?");
        string newName = Console.ReadLine(); 
        alltrainers[editingID].Setname(newName);
        break;

        case "2":
        Console.WriteLine("What would you like the mailiing address to be?");
        string newAddress = Console.ReadLine(); 
        alltrainers[editingID].SetmailingAddress(newAddress);
        break;

        case "3":
        Console.WriteLine("What would you like the email address to be?");
        string newemailAddress = Console.ReadLine(); 
        alltrainers[editingID].SettrainerEmail(newemailAddress);
        break;

        case "4":
        bool deleted =! alltrainers[editingID].Getdeleted();
        alltrainers[editingID].Setdeleted(deleted);
        break;

        default:
        Console.WriteLine("Invalid option! Reverting back to main menu.");
        Console.ReadKey();
        MainMenu();
        break;
    }
    TrainerUtility.SetAllTrainers(alltrainers);

}

 

static void ListingFunctions(){
    Console.WriteLine("Welcome to Listing Functions! Enter 1 to add a listing, 2 to edit/delete a listing, or 3 to go back to the main menu.");
   string userInput = Console.ReadLine(); //read in user input 

    if(userInput == "1"){
        AddAListing();
 
    }
    else if(userInput =="2"){
        EditAListing();

    }
    
    else if(userInput == "3"){
        MainMenu();
    }
    else{
        Console.WriteLine("Invalid option! Please enter a valid option.");
        Console.WriteLine("Welcome to Listing Functions! Enter 1 to add a listing, 2 to edit a listing, 3 to delete a listing, and 4 to go back to the main menu.");
        userInput = Console.ReadLine();
    }
}

 static void AddAListing(){
   Console.WriteLine("What is the trainer's name?");
    string trainerName = Console.ReadLine();
    Console.WriteLine("What is the date of the session?");
    string dateOfSession = Console.ReadLine();
    Console.WriteLine("What is the time of the session?");
    string timeOfSession = Console.ReadLine();
    Console.WriteLine("What is the cost of the session?");
    int costOfSession = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the status of the session?");
    string status = Console.ReadLine();

    Listing[] allListings = ListingUtility.GetAllListings(); 
    int allListingsCount = ListingUtility.GetCount(); 
    Listing newListing = new Listing(allListingsCount, trainerName, dateOfSession, timeOfSession, costOfSession, false, false);

    allListings[allListingsCount] = newListing; 
    ListingUtility.IncCount();
    ListingUtility.SetAllListings(allListings); 
    ListingUtility.WriteOutListings(); 
    MainMenu(); //go back to main menu at the end 

}

 static void EditAListing(){
     ListingUtility.DisplayAllListings(); 
    Console.WriteLine("Enter the listing ID for the listing you would like to edit.");
    int editingID = int.Parse(Console.ReadLine()); 
    Console.WriteLine("What would you like to edit. Enter 1 to edit the trainer name, 2 to edit the date of the session, 3 to edit the time of the session, 4 to edit the cost of the session, 5 to edit the status, or 6 to delete"); 
    string userInput = Console.ReadLine(); 
    Listing[] alllistings = ListingUtility.GetAllListings(); 
    switch (userInput)
    {
        case "1": 
        Console.WriteLine("What would you like the name to be?");
        string newTrainerName = Console.ReadLine(); 
        alllistings[editingID].SettrainerName(newTrainerName);
        break;

        case "2":
        Console.WriteLine("What would you like the date of the session to be?");
        string newdate = Console.ReadLine(); 
        alllistings[editingID].SetdateOfSession(newdate);
        break;

        case "3":
        Console.WriteLine("What would you like cost of the session to be?");
        int newcostofSession = int.Parse(Console.ReadLine()); 
        alllistings[editingID].SetcostOfSession(newcostofSession);
        break;

        case "4":
        bool status =! alllistings[editingID].Getstatus();
        alllistings[editingID].Setdeleted(status);
        break;

        case "5":
        bool deleted =! alllistings[editingID].Getdeleted();
        alllistings[editingID].Setdeleted(deleted);
        break;

        default:
        Console.WriteLine("Invalid option! Reverting back to main menu.");
        Console.ReadKey();
        MainMenu();
        break;
    }
    ListingUtility.SetAllListings(alllistings); 
}



static void BookingFunctions(){
    Console.WriteLine("Welcome to booking functions! Enter 1 to view available training sessions, 2 to book a session, or 3 to return to the main menu.");
    string userInput = Console.ReadLine(); //read in user input 

    if(userInput == "1"){
        ViewASession(); //go to method to view a session 
        
    }
    else if(userInput == "2"){
        BookASession(); //go to method to book a session 

    }
    else if(userInput == "3"){
        MainMenu();
    }
    else{
        Console.WriteLine("Invalid input, please enter a valid option."); 
        Console.WriteLine("Welcome to booking functions! Enter 1 to view available training sessions, 2 to book a session, or 3 to return to the main menu.");
        userInput = Console.ReadLine();
    }
}

static void ViewASession(){
    ListingUtility.DisplayAllListings();
    Console.ReadKey(); 
    BookingFunctions(); 
    
}

static  void BookASession(){
    ListingUtility.DisplayAllListings();
    Console.WriteLine("Enter the listing ID that you would like to book."); 
    int userInput = int.Parse(Console.ReadLine());
  Listing[] listings = ListingUtility.GetAllListings(); 
    while(listings[userInput].Getstatus()){
        Console.WriteLine("This listing has already been taken, please select a new one.");
         ListingUtility.DisplayAllListings();
        Console.WriteLine("Enter the listing ID that you would like to book."); 
         userInput = int.Parse(Console.ReadLine());

    }
    Console.WriteLine("What is the session Id?");
    string sessionId = Console.ReadLine();
     Console.WriteLine("What is the customers's name?");
    string customerName = Console.ReadLine();
    Console.WriteLine("What is the customer's email?");
    string customerEmail = Console.ReadLine();
    Console.WriteLine("What is the date of the session?");
    string trainingDate = Console.ReadLine();
    Console.WriteLine("What is the trainer Id?");
    int trainerId = int.Parse(Console.ReadLine());
    Console.WriteLine("What is the trainer's name?");
    string trainerName = (Console.ReadLine());
    string status = "true";

    Bookings[] allBookings = BookingUtility.GetAllBookings(); 
    int allBookingsCount = BookingUtility.GetCount(); 
    Bookings newBooking = new Bookings(allBookingsCount, customerName, customerEmail, trainingDate, trainerId, trainerName, status); //added true for the status to show that is is now taken 

    allBookings[allBookingsCount] = newBooking; 
    BookingUtility.IncCount();
    BookingUtility.SetAllBookings(allBookings); 
    BookingUtility.WriteOutBookings(); 
    MainMenu(); //go back to main menu at the end 
    

}

 static void ReportFunctions(){
    Console.WriteLine("Welcome to report functions! Enter 1 to view individual customer sessions, 2 to view historical customer sessions, 3 to view a historical revenue report, or 4 to exit"); 
    string userInput = Console.ReadLine();//read in the user's input 
    if(userInput == "1"){
       Report.IndividualCustomerSessions(); //go to method for individual customer sessions 
    }
    else if(userInput =="2"){
        Report.HistoricalCustomerSessions(); //go to method for historical customer sessions 

    }
    else if(userInput == "3"){
        Report.HistoricalRevenueReport(); //go to method for historical revenue report 

    }
    else if(userInput == "4"){
        MainMenu();

        //go back to main menu 
    }
    else{
        Console.WriteLine("Invalid input! Please select another option.");
        Console.WriteLine("Welcome to report functions! Enter 1 to view individual customer sessions, 2 to view historical customer sessions, 3 to view a historical revenue report, or 4 to exit"); 
        userInput = Console.ReadLine();
    }


}

 static void ExitProgram(){ 
    Console.WriteLine("Thank you so much for visiting our site! ");
}