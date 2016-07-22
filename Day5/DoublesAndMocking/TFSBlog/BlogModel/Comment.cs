
using System;

namespace BlogModel
{
   public class Comment
   {
      public virtual int Id { get; set; }
      public virtual int PostId { get; set; }
      public virtual string Value { get; set; }
      public virtual string Name { get; set; }
      public virtual string EMail { get; set; }
      public virtual DateTime DateCommented { get; set; }
      public virtual Post Post { get; set; }
   }
}
