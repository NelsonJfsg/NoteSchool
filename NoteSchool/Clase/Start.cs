using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteSchool.Layout;

namespace NoteSchool {
    
    //Clase para iniciar el main.
    class Start {


        //Main del programa.
        public static void Main() {
            
            //ejecutar load.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ScLoad());
            
        }

    }
}
