using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTecnologiaServices.Modules.Erp.Api.Models.FieldType
{
    internal class RelationFieldMeta : Field
    {
        [JsonProperty(PropertyName = "fieldType")]
        public static FieldType FieldType { get { return FieldType.RelationField; } }

        [JsonProperty(PropertyName = "relationFields")]
        public List<Field> Fields { get; set; }


        [JsonProperty(PropertyName = "relation")]
        public EntityRelation Relation { get; set; }

        [JsonIgnore]
        internal Entity OriginEntity { get; set; }

        [JsonIgnore]
        internal Entity TargetEntity { get; set; }

        [JsonIgnore]
        internal Field OriginField { get; set; }

        [JsonIgnore]
        internal Field TargetField { get; set; }

        [JsonIgnore]
        public Entity Entity { get; set; }

        [JsonIgnore]
        public string Direction { get; set; }


        public RelationFieldMeta()
        {
            Relation = null;
            Fields = new List<Field>();
        }

        public RelationFieldMeta(Field field) : base(field)
        {
            Entity = null;
            Relation = null;
            Fields = new List<Field>();
        }
    }
}
