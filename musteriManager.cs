using System;
using System.Collections.Generic;
using System.Text;


namespace ClassMethodDemos
{

    class musteriManager
    {
        public void Add(string ID, string name, string Job, int Age)
        {
            Console.WriteLine(ID + " " + name + " " + Job + " " + Age + "--> Listeye eklendi");
        }
        public void List(string ID, string name, string Job, int Age)
        {
            Console.WriteLine(ID + " " + name + " " + Job + " " + Age + "--> Listelendi.");
        }
        public void Sil(string ID, string name, string Job, int Age)
        {
            Console.WriteLine(ID + " " + name + " " + Job + " " + Age + "--> Listeden silindi");
        }



    }









}