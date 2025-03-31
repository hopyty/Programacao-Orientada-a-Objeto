interface IVoar {
    void voar();
}


interface INadar {
    void nadar();
}


class Pato implements IVoar, INadar {
    @Override
    public void voar() {
        System.out.println("Pato está voando!");
    }
    
    @Override
    public void nadar() {
        System.out.println("Pato está nadando!");
    }
}


class Aguia implements IVoar {
    @Override
    public void voar() {
        System.out.println("Águia está voando alto!");
    }
}

class Peixe implements INadar {
    @Override
    public void nadar() {
        System.out.println("Peixe está nadando rápido!");
    }
}


class Principal {
    public static void main(String[] args) {
        Pato pato = new Pato();
        Aguia aguia = new Aguia();
        Peixe peixe = new Peixe();
        

        System.out.println("--- Animais que voam ---");
        IVoar[] aves = {pato, aguia};
        for (IVoar ave : aves) {
            ave.voar();
        }
        

        System.out.println("\n--- Animais que nadam ---");
        INadar[] aquaticos = {pato, peixe};
        for (INadar aquatico : aquaticos) {
            aquatico.nadar();
        }
    }
}
