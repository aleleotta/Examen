namespace Entities
{
    public class clsPersona
    {
        #region Attributes
        private int id = 0;
        private string nombre = "";
        private string apellidos = "";
        private int idDept = 0;
        #endregion

        #region Properties
        public int Id => id;
        public string Nombre => nombre;
        public string Apellidos => apellidos;
        public int IdDept => idDept;
        #endregion

        #region Constructors
        public clsPersona() { }
        public clsPersona(int id, string nombre, string apellidos, int idDept)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.idDept = idDept;
        }
        public clsPersona(clsPersona persona)
        {
            id = persona.id;
            nombre = persona.nombre;
            apellidos = persona.apellidos;
            idDept = persona.idDept;
        }
        #endregion
    }
}
