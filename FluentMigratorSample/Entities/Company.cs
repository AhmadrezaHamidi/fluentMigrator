using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FluentMigratorSample.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int CompanyId { get; set; }
    }
    #region flow

    [Table("Flow")]
    public class Flow
    {
        private Version _version = new("0.0.1");
        public Flow()
        {

        }

        public Flow(string uniqeId, DateTime createdAt,
            Version flowVersion, int userId,
            int flowTypeId, string flowTypeName,
            string flowTypeTitle)
        {
            UniqeId = uniqeId;
            CreatedAt = createdAt;
            FlowVersion = flowVersion;
            UserId = userId;
            FlowTypeId = flowTypeId;
            FlowTypeName = flowTypeName;
            FlowTypeTitle = flowTypeTitle;
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string UniqeId { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Version { get; private set; } = "0.0.1";
        [NotMapped]
        public Version FlowVersion
        {
            get { return _version; }
            set
            {
                _version = value;
                Version = _version.ToString();
            }
        }
        public int UserId { get; set; }
        public int FlowTypeId { get; set; }
        public string FlowTypeName { get; set; }
        public string FlowTypeTitle { get; set; }
    }

    #endregion flow

    #region FlowType

    public class FlowType
    {
        public FlowType()
        {

        }
        public FlowType(int id, string name, string title, int period)
        {
            Id = id;
            Name = name;
            Title = title;
            Period = period;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }

        /// <summary>
        /// minutes
        /// </summary>
        public int Period { get; set; }
    }

    #endregion FlowType



    #region FlowActivity

    public class FlowActivity
    {
        public FlowActivity()
        {

        }
        public FlowActivity(string uniqeId, int pervioseId,
            string pervioseUniqeId, DateTime createdAt,
            string flowUniqeId, int flowActivityTypeId, string flowActivityTypeName,
            string flowActivityTypeTitle, int priority)
        {
            UniqeId = uniqeId;
            PervioseId = pervioseId;
            PervioseUniqeId = pervioseUniqeId;
            CreatedAt = createdAt;
            FlowUniqeId = flowUniqeId;
            FlowActivityTypeId = flowActivityTypeId;
            FlowActivityTypeName = flowActivityTypeName;
            FlowActivityTypeTitle = flowActivityTypeTitle;
            Priority = priority;
        }

        public int Id { get; set; }

        public string UniqeId { get; set; }

        public int PervioseId { get; set; }

        public string PervioseUniqeId { get; set; }

        public DateTime CreatedAt { get; set; }

        public int FlowId { get; set; }

        public string FlowUniqeId { get; set; }

        public int FlowActivityTypeId { get; set; }

        public string FlowActivityTypeName { get; set; }

        public string FlowActivityTypeTitle { get; set; }

        public int Priority { get; set; }
    }

    #endregion FlowActivity

    #region FlowActivityType

    public class FlowActivityType
    {
        public FlowActivityType()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public int Priority { get; set; }

        public FlowActivityType(int id, string name, string title, int priority)
        {
            Id = id;
            Name = name;
            Title = title;
            Priority = priority;
        }
    }

    #endregion FlowActivityType

    public class StatusType
    {
        public StatusType(int id, string name, string title)
        {
            Id = id;
            Name = name;
            Title = title;
        }


        public StatusType()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
    }



}
