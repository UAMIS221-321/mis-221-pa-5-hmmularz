namespace mis_221_pa_5_hmmularz
{
    public class TrainerUtility
    {
        static private Trainer[] allTrainers;

        static private int count; 

        static public void SetAllTrainers(Trainer[] allTrainers){
            TrainerUtility.allTrainers = allTrainers;
        }

        static public Trainer[] GetAllTrainers(){
                return TrainerUtility.allTrainers;
        }

     static public void SetCount(int count){
            TrainerUtility.count = count;
        }

        static public int GetCount(){
                return  TrainerUtility.count;
        }


        static public void IncCount(){
            TrainerUtility.count++; 

        }

        static public void ReadInTrainers(){ //stream reader 

        //open 
        StreamReader rdr = new StreamReader("trainers.txt"); //used RDR instead of In.File 
        TrainerUtility.SetCount(0);
        Trainer[] allTrainers = new Trainer[100];

        //process
       string line =  rdr.ReadLine(); 
        while( line != null){
            string [] temp = line.Split("#"); 
            allTrainers [TrainerUtility.GetCount()] = new Trainer(int.Parse(temp[0]), temp[1], temp[2], temp[3], bool.Parse(temp[4]));
            TrainerUtility.IncCount(); 
            line =  rdr.ReadLine(); 

        }

        //close 
        rdr.Close();
        TrainerUtility.allTrainers = allTrainers; 


        }

        static public void WriteOutTrainers(){ 
            StreamWriter sw = new StreamWriter("trainers.txt");
                for(int i = 0; i < TrainerUtility.count; i++){
                sw.WriteLine(TrainerUtility.allTrainers[i].ToFile());

                }
        sw.Close(); 
        }
    static public void DisplayAllTrainers(){
        for(int i= 0; i < TrainerUtility.count; i++){
            Console.WriteLine($"{allTrainers[i].GettrainerId()} {allTrainers[i].Getname()} {allTrainers[i].GetmailingAddress()} {allTrainers[i].GettrainerEmail()} {allTrainers[i].Getdeleted()} ");
        }
    }

    }

}