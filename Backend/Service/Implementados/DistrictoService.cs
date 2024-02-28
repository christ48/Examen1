using Backend.Models;
using Backend.Service.Interface;
using Dal.Interface;
using Entities.Entities;
using Microsoft.Identity.Client;

namespace Backend.Service.Implementados
{
    public class DistrictoService : IDistrictoService
    {

        public IUnidadDeTrabajo _unidadDeTrabajo;

        public DistrictoService(IUnidadDeTrabajo unidadDeTrabajo) {
        
            _unidadDeTrabajo = unidadDeTrabajo;
        }


      


        public bool addDistricto(DistrictoModel districto)
        {
            Distrito entity = Convertir(districto);
            _unidadDeTrabajo._DistritoDal.Add(entity);
            return _unidadDeTrabajo.Complete();
        }

        public bool deleteDistricto(DistrictoModel districto)
        {
           Distrito entity= Convertir(districto);
            _unidadDeTrabajo._DistritoDal.Remove(entity);
            return _unidadDeTrabajo.Complete(); 
        }

        public DistrictoModel GetbyId(int id)
        {
           var entity =_unidadDeTrabajo._DistritoDal.get(id);
            DistrictoModel districtoModel=Convertir(entity); 
            return districtoModel;
        }

        public IEnumerable<DistrictoModel> GetDistrictos()
        {
           var result =_unidadDeTrabajo._DistritoDal.GetAll();
            List<DistrictoModel> lista= new List<DistrictoModel>();
            foreach (var districto in result) {
            
                lista.Add(Convertir(districto));

            }
            return lista;
        }

        public bool updateDistricto(DistrictoModel districto)
        {
           Distrito entity= Convertir(districto);
            _unidadDeTrabajo._DistritoDal.Update(entity);
            return _unidadDeTrabajo.Complete();
        }


        DistrictoModel Convertir(Distrito districto)
        {
            return new DistrictoModel
            {


                DistritoId = districto.DistritoId,
                Nombre = districto.Nombre
            };



        }

        Distrito Convertir(DistrictoModel districto)
        {
            return new Distrito
            {
                DistritoId = districto.DistritoId,
                Nombre = districto.Nombre
            };
            
        }
    }
}
