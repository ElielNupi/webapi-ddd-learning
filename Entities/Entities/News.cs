using Entities.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    [Table("TB_NEWS")]
    public class News : Notification
    {
        [Column("NTC_ID")]
        public int Id { get; set; }

        [Column("NTC_TITLE")]
        [MaxLength(255)]
        public string Title { get; set; }

        [Column("NTC_DESCRIPTION")]
        [MaxLength(300)]
        public string Description { get; set; }

        [Column("NTC_ATIVO")]
        public bool Active { get; set; }

        [Column("NTC_REGISTER_DATE")]
        public DateTime RegisterDate { get; set; }

        [Column("NTC_UPLOAD_DATE")]
        public DateTime UploadDate { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
