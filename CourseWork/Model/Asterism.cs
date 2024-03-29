﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CourseWork.Model
{
    public class Asterism : ModelItem
    {
        public int ID { get; private set; }
        public string Name { get; private set; }
        public double Square { get; private set; }

        public override string DataTableName { get { return "AsterismTable"; } }
        public override string ViewTableName { get { return "Созвездие"; } }
        public override string IdFieldName { get { return "id"; } }

        public Asterism() : base() { }
        public Asterism(string name, double square, int id = Constants.DefaultIndex) : base()
        {
            this.ID = id;
            this.Name = name;
            this.Square = square;

            PostDataLoadingHandle();
            ConfigureViewFields();
        }

        protected override void ConfigureDataFields()
        {
            AddFieldConfig(item => ID = Convert.ToInt32(item[0]), "id");
            AddFieldConfig(item => Name = item[0].ToString(), "name");
            AddFieldConfig(item => Square = Convert.ToInt32(item[0].ToString().Replace('.', ',')), "square");
        }

        protected override void ConfigureFieldGetters()
        {
            FieldsGetters.Add("id", () => ID == Constants.DefaultIndex ? null : ID.ToString());
            FieldsGetters.Add("name", () => Name);
            FieldsGetters.Add("square", () => Square.ToString().Replace(',', '.'));
        }

        protected override void ConfigureViewFields()
        {
            ViewConfig.Add("Название", () => Name);
            ViewConfig.Add("Площадь", () => Square);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
