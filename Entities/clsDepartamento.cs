namespace Entities
{
    public class clsDepartamento
    {
        #region Attributes
        private int id = 0;
        private string nombre = "";
        #endregion

        #region Properties
        public int Id => id;
        public string Nombre => nombre;
        #endregion

        #region Constructors
        public clsDepartamento() { }
        public clsDepartamento(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public clsDepartamento(clsDepartamento dept)
        {
            id = dept.Id;
            nombre = dept.Nombre;
        }
        #endregion
    }
}
