using System;
using System.Collections.Generic;
using System.Data;
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
        private string imagen;

        public string LicensePlate
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Brand
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Model
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Price
        {
            get { return precio; }
            set { precio = value; }
        }
        public string Description
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public string imgURL
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public ENCar()
        {

        }
        public ENCar(string matricula, string marca, string modelo, int precio, string descripcion, string imagen)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
            this.descripcion = descripcion;
            this.imagen = imagen;
        }

        public DataSet createCar()
        {
            CADCar car = new CADCar();
            return car.createCar(this);
        }

        public DataSet deleteCar()
        {
            CADCar car = new CADCar();
            return car.deleteCar(this);
        }

        public DataSet updatePriceCar(int precio)
        {
            CADCar car = new CADCar();
            this.precio = precio;
            return car.updatePriceCar(this);
        }

        public DataSet updateDescriptionCar(string descripcion)
        {
            CADCar car = new CADCar();
            this.descripcion = descripcion;
            return car.updateDescriptionCar(this);
        }

        public DataSet listAllCars()
        {
            CADCar car = new CADCar();
            return car.listAllCars();
        }
    }
}
