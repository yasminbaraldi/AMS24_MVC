using System.ComponentModel;

public abstract class Car : Vehicles
{ 
    public int Accelerate {get;set;}
       public void On()
     {
        Accelerate++;
        
     }

     public void Brake()
     {
        Accelerate--;
     }
}
