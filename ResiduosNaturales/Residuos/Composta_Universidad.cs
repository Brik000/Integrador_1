using System;
namespace Residuos
{
    public class Composta_Universidad{

        private int Capacidad;
        private int Cantidad_Actual;
        private bool Espacio_Disponible;
        private ResiduosNaturales residuo_Actual;



        public Composta_Universidad(){
            Capacidad = 12345;
            Cantidad_Actual = 0;
            Espacio_Disponible = true;
        }


        public void AgregarResiduos(int cantidadAgregar){
            if(Capacidad>cantidadAgregar&&Espacio_Disponible){
                Capacidad = Capacidad - cantidadAgregar;
                Cantidad_Actual = Cantidad_Actual + cantidadAgregar;

                if(Capacidad==0){
                    Espacio_Disponible = false;
                }

            }else{
                throw new Exception("La composta ya esta llena, vuelva mas tarde");
            }
        }


        public void RetirarResiduos(int cantidadRetirar){

            if(Cantidad_Actual>0 && cantidadRetirar<Cantidad_Actual && cantidadRetirar<=Capacidad){

                Cantidad_Actual = Cantidad_Actual - cantidadRetirar;

                Capacidad = Capacidad + cantidadRetirar;

                if(!Espacio_Disponible){
                    if(Capacidad>0){
                        Espacio_Disponible = true;
                    }
                }
                   
            }else{
                throw new Exception("La composta no tiene suficeintes residuos");
            }
        }




    }
}
