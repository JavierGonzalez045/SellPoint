﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionSellpoint_v1._0.CodigoFuente
{
    internal class ComboDeAyuda
    {
        public static void LlenarGrupoDeEntidad(ComboBox cmb)
        {
            DataTable tabla_grupo_de_entidades = new DataTable();
            tabla_grupo_de_entidades.Columns.Add("IdGrupoEntidad");
            tabla_grupo_de_entidades.Columns.Add("Descripcion");
            tabla_grupo_de_entidades.Rows.Add("0", "Seleccionar");
            try
            {
                DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT IdGrupoEntidad, Descripcion FROM GruposEntidades WHERE NoEliminable = 0");
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        foreach (DataRow grupos_de_entidades in tabladedatos.Rows)
                        {
                            tabla_grupo_de_entidades.Rows.Add(grupos_de_entidades["IdGrupoEntidad"], grupos_de_entidades["Descripcion"]);
                        }
                    }

                }
                cmb.DataSource = tabla_grupo_de_entidades;
                cmb.ValueMember = "IdGrupoEntidad";
                cmb.DisplayMember = "Descripcion";
            }
            catch
            {
                cmb.DataSource = tabla_grupo_de_entidades;
            }
        }

        public static void LlenarTiposDeEntidad(ComboBox cmb)
        {
            DataTable tabla_tipos_de_entidades = new DataTable();
            tabla_tipos_de_entidades.Columns.Add("ID");
            tabla_tipos_de_entidades.Columns.Add("[Grupo de entidad]");
            tabla_tipos_de_entidades.Columns.Add("[Tipo de entidad]");
            tabla_tipos_de_entidades.Rows.Add("0", "Seleccionar");
            try
            {
                DataTable tabladedatos = AccesoABaseDeDatos.Seleccionar("SELECT ID, [Grupo de entidad], [Tipo de entidad] from v_TipoEntidades");
                if (tabladedatos != null)
                {
                    if (tabladedatos.Rows.Count > 0)
                    {
                        foreach (DataRow tipos_de_entidades in tabladedatos.Rows)
                        {
                            tabla_tipos_de_entidades.Rows.Add(tipos_de_entidades["ID"], tipos_de_entidades["[Grupo de entidad]"], tipos_de_entidades["[Tipo de entidad]"]);
                        }
                    }

                }
                cmb.DataSource = tabla_tipos_de_entidades;
                cmb.ValueMember = "ID";
                cmb.DisplayMember = "[Grupo de entidad]";
                cmb.DisplayMember = "[Tipo de entidad]";
            }
            catch
            {
                cmb.DataSource = tabla_tipos_de_entidades;
            }
        }
    }
}