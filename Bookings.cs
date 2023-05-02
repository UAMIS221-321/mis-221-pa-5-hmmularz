namespace mis_221_pa_5_hmmularz
{
    public class Bookings
    {
        private int sessionId;

        private string customerName; 

        private string customerEmail; 

        private string trainingDate;

        private int trainerId; 

        private string trainerName; 

        private string status;

        public Bookings(int sessionId, string customerName, string customerEmail, string trainingDate, int trainerId, string trainerName, string status)
        {
            this.sessionId = sessionId;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerId = trainerId;
            this.trainerName = trainerName;
            this.status = status;
        }

        public void SetsessionId(int sessionId){
            this.sessionId = sessionId; 
        }

        public int GetsessionId(){
            return this.sessionId; 
        }
        public void SetcustomerName(string customerName){
            this.customerName = customerName; 
        }

        public string GetcustomerName(){
            return this.customerName; 
        }

         public void SetcustomerEmail(string customerEmail){
            this.customerEmail = customerEmail; 
        }

        public string GetcustomerEmail(){
            return this.customerEmail; 
        }
         public void SettrainingDate(string trainingDate){
            this.trainingDate = trainingDate; 
        }

        public string GettrainingDate(){
            return this.trainingDate; 
        }

         public void SettrainerId(int trainerId){
            this.trainerId = trainerId; 
        }

        public int GettrainerId(){
            return this.trainerId; 
        }
         public void SettrainerName(string trainerName){
            this.trainerName= trainerName; 
        }

        public string GettrainerName(){
            return this.trainerName; 
        }
         public void Setstatus(string status){
            this.status = status; 
        }

        public string Getstatus(){
            return this.status; 
        }

        public string ToFile(){
            return this.sessionId + '#' + this.customerName + "#" + this.customerEmail + '#' + this.trainingDate + '#' + this.trainerId + '#' + this.trainerName + "#" + this.status;
        }
    }
}