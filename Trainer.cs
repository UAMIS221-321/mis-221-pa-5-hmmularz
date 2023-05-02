namespace mis_221_pa_5_hmmularz
{
    public class Trainer
    {
        private bool deleted; 
        private int trainerId;
        private string name; 
        private string mailingAddress; 

        private string trainerEmail;

        public Trainer(int trainerId, string name, string mailingAddress, string trainerEmail, bool deleted)
        {
            this.deleted = deleted;
            this.trainerId = trainerId;
            this.name = name;
            this.mailingAddress = mailingAddress;
            this.trainerEmail = trainerEmail;
        }

        public void SettrainerId(int trainerId){
            this.trainerId = trainerId; 
        }
        public int GettrainerId(){
            return this.trainerId; 
        }
           public void Setname(string name){
            this.name = name; 
        }
        public string Getname(){
            return this.name; 
        }
        public void SetmailingAddress(string mailingAddress){
            this.mailingAddress = mailingAddress; 
        }
        public string GetmailingAddress(){
            return this.mailingAddress; 
        }
        public void SettrainerEmail(string trainerEmail){
            this.trainerEmail = trainerEmail; 
        }
        public string GettrainerEmail(){
            return this.trainerEmail; 
        }

        public string ToFile(){
            return this.trainerId + "#" + this.name + "#" + this.mailingAddress + "#"  + this.trainerEmail + "#"  + this.deleted;
        }
         public bool Getdeleted(){
            return this.deleted; 
        }
        public void Setdeleted(bool deleted){
            this.deleted = deleted; 
        }
    }


}