﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Connection
{
    public class datosBasicos
    {
        #region Atributos
        private int id;
        private string codMaq;
        private string codTrailer;
        private string id_operario;
        private string fecha_inicio;
        private string fecha_fin;
        private string hora_inicio;
        private string hora_fin;
        private string sistema;
        private decimal horas_programadas;
        private int horometro_inicial;
        private int horometro_final;
        private int kilometro_inicial;
        private int kilometro_final;
        private int kilometro_i_trailer;
        private int kilometro_f_trailer;
        private string id_centroCostos;
        private int id_frente;
        private int id_Frente;
        private string Frente;
        private string proyecto;
        private string id_proyecto;
        #endregion

        #region Metodos Set Get
        public int _id
        {
            get { return id; }
            set { id = value; }
        }
        public string _codMaq
        {
            get { return codMaq; }
            set { codMaq = value; }
        }
        public string _codTrailer
        {
            get { return codTrailer; }
            set { codTrailer = value; }
        }
        public string _id_operario
        {
            get { return id_operario; }
            set { id_operario = value; }
        }
        public decimal _horas_programadas
        {
            get { return horas_programadas; }
            set { horas_programadas = value; }
        }
        public string _fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }
        public string _fecha_fin
        {
            get { return fecha_fin; }
            set { fecha_fin = value; }
        }
        public int _horometro_inicial
        {
            get { return horometro_inicial; }
            set { horometro_inicial = value; }
        }
        public int _horometro_final
        {
            get { return horometro_final; }
            set { horometro_final = value; }
        }
        public int _kilometro_inicial
        {
            get { return kilometro_inicial; }
            set { kilometro_inicial = value; }
        }
        public int _kilometro_final
        {
            get { return kilometro_final; }
            set { kilometro_final = value; }
        }
        public int _kilometro_i_trailer
        {
            get { return kilometro_i_trailer; }
            set { kilometro_i_trailer = value; }
        }
        public int _kilometro_f_trailer
        {
            get { return kilometro_f_trailer; }
            set { kilometro_f_trailer = value; }
        }
        public string _id_centroCostos
        {
            get { return id_centroCostos; }
            set { id_centroCostos = value; }
        }
        public int _id_frente
        {
            get { return id_frente; }
            set { id_frente = value; }
        }
        public string _sistema
        {
            get { return sistema; }
            set { sistema = value; }
        }
        public string _proyecto
        {
            get { return proyecto; }
            set { proyecto = value; }
        }
        public string _id_proyecto
        {
            get { return id_proyecto; }
            set { id_proyecto = value; }
        }
        public string _Frente
        {
            get { return Frente; }
            set { Frente = value; }
        }
        public int _id_Frente
        {
            get { return id_Frente; }
            set { id_Frente = value; }
        }
        #endregion

        #region Metodos
        public int InsertDataBasic(int action, string id_codMaq, string id_operario, string fecha_inicio, string hora_inicio, int horometro_inicial, int horometro_final, int kilometro_inicial, int kilometro_final, string id_codTrailer, int kilometro_i_trailer, int kilometro_f_trailer, string id_centroCostos, int id_frente)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm1");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id_codMaq", id_codMaq);
            comando.Parameters.AddWithValue("@id_operario", id_operario);
            comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
            comando.Parameters.AddWithValue("@hora_inicio", hora_inicio);
            comando.Parameters.AddWithValue("@horometro_inicial", horometro_inicial);
            comando.Parameters.AddWithValue("@horometro_final", horometro_final);
            comando.Parameters.AddWithValue("@kilometro_inicial", kilometro_inicial);
            comando.Parameters.AddWithValue("@kilometro_final", kilometro_final);
            comando.Parameters.AddWithValue("@id_codTrailer", id_codTrailer);
            comando.Parameters.AddWithValue("@kilometro_i_trailer", kilometro_i_trailer);
            comando.Parameters.AddWithValue("@kilometro_f_trailer", kilometro_f_trailer);
            comando.Parameters.AddWithValue("@id_centroCostos", id_centroCostos);
            comando.Parameters.AddWithValue("@id_frente", id_frente);
            return ConexionBD.EjecutarComando(comando);
        }
        public int UpdateDataBasic(int action, string id, int horometro_inicial, int horometro_final, int kilometro_inicial, int kilometro_final, string id_codTrailer, int kilometro_i_trailer, int kilometro_f_trailer, int id_frente)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm1");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
            comando.Parameters.AddWithValue("@horometro_inicial", horometro_inicial);
            comando.Parameters.AddWithValue("@horometro_final", horometro_final);
            comando.Parameters.AddWithValue("@kilometro_inicial", kilometro_inicial);
            comando.Parameters.AddWithValue("@kilometro_final", kilometro_final);
            comando.Parameters.AddWithValue("@id_codTrailer", id_codTrailer);
            comando.Parameters.AddWithValue("@kilometro_i_trailer", kilometro_i_trailer);
            comando.Parameters.AddWithValue("@kilometro_f_trailer", kilometro_f_trailer);
            comando.Parameters.AddWithValue("@id_frente", id_frente);
            return ConexionBD.EjecutarComando(comando);
        }
        public DataTable selectMaquina(int action, string id_codMaq)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm1");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@codMaquina", id_codMaq);
            return ConexionBD.EjecutarSelect(comando);
        }
        public DataTable selectAllReport(int action, string id_codMaq, string id_operario, string fecha_inicio)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm1");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id_codMaq", id_codMaq);
            comando.Parameters.AddWithValue("@id_operario", id_operario);
            comando.Parameters.AddWithValue("@fecha_inicio", fecha_inicio);
            return ConexionBD.EjecutarSelect(comando);
        }
        public DataTable selectTrailer(int action)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm1");
            comando.Parameters.AddWithValue("@action", action);
            return ConexionBD.EjecutarSelect(comando);
        }
        public DataTable validarHorometro(int action, string id_codMaq)
        {
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm1");
            comando.Parameters.AddWithValue("@action", action);
             comando.Parameters.AddWithValue("@id_codMaq", id_codMaq);
            return ConexionBD.EjecutarSelect(comando);
        }
        public DataTable getProjects()
        {
            int action = 8;
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm1");
            comando.Parameters.AddWithValue("@action", action);
            return ConexionBD.EjecutarSelect(comando);
        }
        public DataTable getFrentes(string project)
        {
            int action = 10;
            SqlCommand comando = ConexionBD.crearComandoProc("ReportDailyForm1");
            comando.Parameters.AddWithValue("@action", action);
            comando.Parameters.AddWithValue("@id_centroCostos", project);
            return ConexionBD.EjecutarSelect(comando);
        }
        #endregion

    }
}
