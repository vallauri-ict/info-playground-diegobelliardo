using System;
using System.Web.UI;

namespace OnlineRegisterWebForm
{
    public partial class Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DbTools db = new DbTools();
                string sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES;";
                DropDownListTabelle.DataSource = db.GetDataList(sql);
                DropDownListTabelle.DataBind();
                sql = "SELECT Id, CONCAT(Firstname,' ',LastName) as Description FROM Student ORDER BY LastName, FirstName";
                DropDownListStudenti.DataValueField = "Id";
                DropDownListStudenti.DataTextField = "Description";
                DropDownListStudenti.DataSource = db.GetDataTable(sql);
                DropDownListStudenti.DataBind();
                sql = "SELECT Id, CONCAT(Year,Section,' ',Specialization) as Description FROM Class ORDER BY Specialization,Year,Section";
                DropDownListClassi.DataValueField = "Id";
                DropDownListClassi.DataTextField = "Description";
                DropDownListClassi.DataSource = db.GetDataTable(sql);
                DropDownListClassi.DataBind();
                sql = "SELECT Id, Description FROM Subject ORDER BY Description";
                DropDownListMaterie.DataValueField = "Id";
                DropDownListMaterie.DataTextField = "Description";
                DropDownListMaterie.DataSource = db.GetDataTable(sql);
                DropDownListMaterie.DataBind();
                // load first table at first launch
                DropDownListTabelle_SelectedIndexChanged(sender, e);
            }
        }

        protected void DropDownListTabelle_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbTools db = new DbTools();
            string tableName = DropDownListTabelle.SelectedValue;
            string query = "SELECT * FROM " + tableName;
            loadData(query);
        }

        protected void DropDownListStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {
            int studentId = int.Parse(DropDownListStudenti.SelectedValue);
            // Response.Write(studentId);
            // string query = $"SELECT * FROM Mark WHERE IdStudent = {studentId};";

            string query = $"SELECT DISTINCT CONCAT(st.FirstName, ' ', st.LastName, ' (', c.Year, '-', c.Section, '-', c.Specialization, ')') as Nominativo,su.Description as Materia, m.[When] as Data, m.Mark as Voto FROM Student st, Subject su, Class c, Mark m, MarkClassTeacherSubject mcts, ClassTeacherSubject cts WHERE(st.Id = m.IdStudent) AND cts.Id = mcts.IdClassTeacherSubject AND m.Id = mcts.IdMark AND c.Id = cts.IdClass AND cts.IdSubject=su.Id AND st.ID = { studentId } ORDER BY su.Description ASC, m.[When] DESC";
            loadData(query);
        }

        protected void DropDownListClassi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int classId = int.Parse(DropDownListClassi.SelectedValue);
            string query = $"SELECT su.Description as Materia,CONCAT(c.Year,'-',c.Section,'-',c.Specialization) as Classe,CONCAT(st.FirstName ,'_',st.LastName) as Nominativo, su.Description as Materia, m.[When] as Data, m.Mark as Voto FROM Student st, Subject su, Class c, Mark m, MarkClassTeacherSubject mcts, ClassTeacherSubject cts WHERE(st.Id = m.IdStudent) AND cts.Id = mcts.IdClassTeacherSubject AND m.Id = mcts.IdMark AND c.Id = cts.IdClass AND cts.IdSubject=su.Id AND su.Id = {classId} ORDER BY Nominativo, m.[When] DESC;";
            loadData(query);
        }

        protected void DropDownListMaterie_SelectedIndexChanged(object sender, EventArgs e)
        {
            int subjectId = int.Parse(DropDownListMaterie.SelectedValue);
            string query = "SELECT ...";
            loadData(query);
        }

        private void loadData(string sqlQuery)
        {
            GridViewTable.DataSource = new DbTools().GetDataTable(sqlQuery);
            GridViewTable.DataBind();
        }
    }
}