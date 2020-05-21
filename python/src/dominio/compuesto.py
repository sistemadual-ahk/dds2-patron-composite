from src.dominio.componente import Componente


class Compuesto(Componente):
    __componentes = []

    def operacion(self):
        for componente in self.__componentes:
            componente.operacion()

    def agregar(self, componente):
        self.__componentes.append(componente)

    def eliminar(self, componente):
        self.__componentes.remove(componente)
