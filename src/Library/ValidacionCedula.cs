using System;

using System.Linq;
using System.Collections.Generic;

namespace Program
{
    public class ValidacionCedula
    {
        char[] chequearCedula;
        bool validada =false;
        int suma=0;
        int digito;
        List<string> CedulaEnLista = new List<string>();
        public bool Validate(string id,string name)
        {
            id = id.Replace(".","");
            id = id.Replace("-","");
            chequearCedula = id.ToArray();
           
            if(chequearCedula.Count()==8)
                {
                    foreach (var item in chequearCedula)
                        {
                            CedulaEnLista.Add(item.ToString());    
                                           
                        }
                    if(CedulaEnLista.Count()==8)
                        {
                            suma += (Int32.Parse(CedulaEnLista[0]))*2;                           
                            suma += (Int32.Parse(CedulaEnLista[1]))*9;                         
                            suma += (Int32.Parse(CedulaEnLista[2]))*8;
                            suma += (Int32.Parse(CedulaEnLista[3]))*7;
                            suma += (Int32.Parse(CedulaEnLista[4]))*6;
                            suma += (Int32.Parse(CedulaEnLista[5]))*3;
                            suma += (Int32.Parse(CedulaEnLista[6]))*4;
                            suma = suma %10;
                            suma = (10-suma)%10;                           
                            digito = Int32.Parse(CedulaEnLista[7]);
                            if(suma == digito & name !="")
                            {
                                validada = true;
                            }
                            
                        }
                }
                else
                    {
                        validada = false;
                    }  
        return validada;
        }
    }
}