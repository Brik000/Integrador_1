using System;
namespace Residuos
{
    public class Composta_Universidad
    {

        private int Capacidad;
        private int Cantidad_Actual;
        private bool Espacio_Disponible;
        private ResiduosNaturales[] residuo;
        private int[] cantidadResiduo;



        public Composta_Universidad(){
            Capacidad = 12345;
            Cantidad_Actual = 0;
            Espacio_Disponible = true;

            residuo[0] = new ResiduosNaturales("organico", 1201, "pasto");
            residuo[1] = new ResiduosNaturales("organico", 1202, "agua");
            residuo[2] = new ResiduosNaturales("organico", 1203, "semillas");
            residuo[3] = new ResiduosNaturales("organico", 1204, "papel");
            residuo[4] = new ResiduosNaturales("organico", 1205, "carton");
            residuo[5] = new ResiduosNaturales("organico", 1206, "huesos");
            residuo[6] = new ResiduosNaturales("organico", 1207, "cascara huevos");
            residuo[7] = new ResiduosNaturales("organico", 1208, "excremento animales");
            residuo[8] = new ResiduosNaturales("organico", 1209, "flores");

            cantidadResiduo = new int[residuo.Length];

            for (int i = 0; i < cantidadResiduo.Length;i++){
                int a = 0;
                cantidadResiduo[i] = a;
            }

        }

        public int Elresiduoes(ResiduosNaturales este){

            switch (este.Nombre){

                case "pasto":
                    return 0;


                case "agua":
                    return 1;

                case "semillas":
                    return 2;

                case "papel":
                    return 3;
                   
                case "carton":
                    return 4;
                  
                case "huesos":
                    return 5;
                   
                case "cascara huevos":
                    return 6;

                case "excremento animales":
                    return 7;

                case "flores":
                    return 8;

            }
            return -1;
        }

        public void AgregarResiduos(int cantidadAgregar,ResiduosNaturales agregar){
            if(Capacidad>cantidadAgregar&&Espacio_Disponible){
                Capacidad = Capacidad - cantidadAgregar;
                Cantidad_Actual = Cantidad_Actual + cantidadAgregar;
                cantidadResiduo[Elresiduoes(agregar)] += cantidadAgregar;

                if(Capacidad==0){
                    Espacio_Disponible = false;
                }

            }else{
                throw new Exception("La composta ya esta llena, vuelva mas tarde");
            }
        }


        public void RetirarResiduos(int cantidadRetirar,ResiduosNaturales retirar){

            if(Cantidad_Actual>0 && cantidadRetirar<Cantidad_Actual && cantidadRetirar<=Capacidad){

                Cantidad_Actual = Cantidad_Actual - cantidadRetirar;

                Capacidad = Capacidad + cantidadRetirar;
                cantidadResiduo[Elresiduoes(retirar)] -= cantidadRetirar;
                if(!Espacio_Disponible){
                    if(Capacidad>0){
                        Espacio_Disponible = true;
                    }
                }
                   
            }else{
                throw new Exception("La composta no tiene suficeintes residuos");
            }
        }

public int 


    }
}
