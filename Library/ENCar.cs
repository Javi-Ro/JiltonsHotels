using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class ENCar
    {
        private string matricula;
        private string marca;
        private string modelo;
        private int precio;
        private string descripcion;
        public string LicensePlate
        {
            get { return matricula; }
            private set { matricula = value; }
        }

        public string Brand
        {
            get { return marca; }
            private set { marca = value; }
        }

        public string Model
        {
            get { return modelo; }
            private set { modelo = value; }
        }

        public int Price
        {
            get { return precio; }
            private set { precio = value; }
        }
        public string Description
        {
            get { return descripcion; }
            private set { descripcion = value; }
        }

        public ENCar(string matricula, string marca, string modelo, int precio, string descripcion)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.descripcion = descripcion;
        }

        public bool createCar()
        {
            CADCar car = new CADCar();
            return car.createCar(this); 
        }

        public bool deleteCar()
        {
            CADCar car = new CADCar();
            return car.deleteCar(this);
        }

        public bool updatePriceCar(int precio)
        {
            CADCar car = new CADCar();
            this.precio = precio;
            return car.updatePriceCar(this);
        }

        public bool updateDescriptionCar(string descripcion)
        {
            CADCar car = new CADCar();
            this.descripcion = descripcion;
            return car.updatePriceCar(this);
        }

        public List<ENCar> listAllCars()
        {
            CADCar car = new CADCar();
            return car.listAllCars();
        }
    }
}
