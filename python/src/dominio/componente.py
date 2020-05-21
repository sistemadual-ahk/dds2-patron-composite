import abc


class Componente(abc.ABC):

    @abc.abstractmethod
    def operacion(self):
        pass
