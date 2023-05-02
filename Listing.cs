namespace mis_221_pa_5_hmmularz
{
    public class Listing

    {
        private bool deleted; 
        private int listingId; 

        private string trainerName; 

        private string dateOfSession;

        private string timeOfSession; 

        private int costOfSession; 

        private bool status; 

        public Listing(int listingId, string trainerName, string dateOfSession, string timeOfSession, int costOfSession, bool status, bool deleted)
        {
            this.deleted = deleted;
            this.listingId = listingId;
            this.trainerName = trainerName;
            this.dateOfSession = dateOfSession;
            this.timeOfSession = timeOfSession;
            this.costOfSession = costOfSession;
            this.status =status;
        }

        public void SetlistingId(int listingId){
            this.listingId = listingId; 
        }

        public int GetlistingId(){
            return this.listingId; 
        }

         public void SettrainerName(string trainerName){
            this.trainerName = trainerName; 
        }

        public string GettrainerName(){
            return this.trainerName; 
        }

        public void SetdateOfSession(string dateOfSession){
            this.dateOfSession = dateOfSession; 
        }

        public string GetdateOfSession(){
            return this.dateOfSession; 
    }

     public void SettimeOfSession(string timeOfSession){
            this.timeOfSession = timeOfSession; 
        }

        public string GettimeOfSession(){
            return this.timeOfSession; 
}
         public void SetcostOfSession(int costOfSession){
            this.costOfSession = costOfSession; 
        }

        public int GetcostOfSession(){
            return this.costOfSession; 

}

 public void Setstatus(bool status){
            this.status = status; 
        }

        public bool Getstatus(){
            return this.status; 

}
    public void Setdeleted(bool deleted){
        this.deleted = deleted; 
    }

    public bool Getdeleted(){
        return this.deleted; 
    }

    public string ToFile(){
        return this.listingId + '#' + this.trainerName + '#' + this.dateOfSession + '#' + this.timeOfSession + '#' + this.costOfSession + '#' + this.status + '#' + this.deleted;
    }
    }


}
