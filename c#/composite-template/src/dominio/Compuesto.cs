using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace composite_template.src.dominio
{
    class Compuesto : Componente
    {
        private List<Componente> componentes;

        public Compuesto()
        {
            this.componentes = new List<Componente>();
        }

        public override void operacion()
        {
            this.componentes.ForEach(c => { c.operacion(); });
        }

        public void agregar(params Componente[] componentes)
        {
            this.componentes.AddRange(componentes);
        }

        public void eliminar(Componente componente)
        {
            this.componentes.Remove(componente);
        }
    }
}
