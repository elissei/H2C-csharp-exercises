namespace exercise_102{
	public class Gauge{
        public int value { get; set; }
        
        public Gauge(){
            this.value = 0;
        }
        public void Increase(){
            if (value <= 5){
                this.value += 1
            }
        }
        public void Decrease(){
            if(value > 0){
                this.value -= 1;
            }
        }
        public bool Full(){
            if(value == 5){
                return true;
            }
            else{
                return false;
            }
        }
    }
}