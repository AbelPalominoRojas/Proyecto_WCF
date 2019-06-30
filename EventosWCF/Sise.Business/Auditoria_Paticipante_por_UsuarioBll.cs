using System;
using System.Collections.Generic;
using Sise.Entities;
using Sise.Repository;

namespace Sise.Business
{
    public class Auditoria_Paticipante_por_UsuarioBll
    {
        public bool registrar(Auditoria_Paticipante_por_Usuario auditoriaparticipanteporusuario)
        {
            return new Auditoria_Paticipante_por_UsuarioRepository().registrar(auditoriaparticipanteporusuario);
        }
    }
}
