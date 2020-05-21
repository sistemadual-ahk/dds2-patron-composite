package dominio;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class Compuesto extends Componente {
    private List<Componente> componentes;

    public Compuesto(){
        this.componentes = new ArrayList<>();
    }

    @Override
    public void operacion(){
        this.componentes.forEach(c -> c.operacion());
    }

    public void agregar(Componente ... componentes){
        Collections.addAll(this.componentes, componentes);
    }

    public void eliminar(Componente componente){
        this.componentes.remove(componente);
    }
}