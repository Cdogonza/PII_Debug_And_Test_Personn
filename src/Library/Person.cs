using System; 
using System.Collections.Generic;

namespace Program 
{ 
    public class Person : ValidacionCedula
    { 
        public string name; 
        public string id;
        bool validadaSioNO;
        public Person(string name, string id) 
        { 
            if (Validate(id,name))
                {
                    this.id = id;
                    this.name = name;
                    validadaSioNO = true; 
                }
                else
                    {
                        validadaSioNO = false;
                    }         
        } 
        public void IntroduceYourself() 
        { 
            if (validadaSioNO)
            {
                Console.WriteLine($"Soy {this.name} y mi cédula es {this.id}");
            }
            else
            {
                Console.WriteLine("Datos Incorrecos Reintente");
            }
             
        } 
    } 
}