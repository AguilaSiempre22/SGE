namespace SGE.Aplicacion;

interface ITramiteRepositorio
{
    void TramiteBaja(Tramite t);
    void TramiteAlta(Tramite t);
    List<Tramite> TramiteConsultaPorEtiqueta(EtiquetaTramite i);
    void TramiteModificacion(Tramite t);
}
