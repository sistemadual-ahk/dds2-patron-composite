<?php
namespace dominio;


class Compuesto extends Componente {
    /**
     * @var Componente[]
     */
    private $componentes;

    public function __construct(){
        $this->componentes = [];
    }

    public function operacion(){
        // TODO: Implement operacion() method.
    }

    public function agregar(Componente ... $componentes){
        $this->componentes = array_merge($this->componentes, $componentes);
    }

    public function eliminar(Componente $componente){
        unset($this->componentes[array_search($componente, $this->componentes)]);
    }
}