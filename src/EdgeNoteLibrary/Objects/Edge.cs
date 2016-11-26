using System;
namespace EdgeNote.Library.Objects
{
    public class Edge : AbstractObject
    {
        /// <summary>
        /// Node that this edge primarily connects to
        /// </summary>
        /// <value>The node identifier.</value>
        public Guid NodeId { get; set; }

        /// <summary>
        /// Node that the edge relates the primary node to
        /// </summary>
        /// <value>The related node identifier.</value>
        public Guid RelatedNodeId { get; set; }

        /// <summary>
        /// The date and time the edge was created in db
        /// </summary>
        /// <value>The created on.</value>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// The date and time the edge was established in reality 
        /// </summary>
        /// <value>The established on.</value>
        public DateTime? EstablishedOn { get; set; }

        /// <summary>
        /// The date and time the edge was broken in reality
        /// </summary>
        /// <value>The broken on.</value>
        public DateTime? BrokenOn { get; set; }

        /// <summary>
        /// Label for the edge.
        /// </summary>
        /// <value>The label identifier.</value>
        public Guid LabelId { get; set; }

        /// <summary>
        /// Freeform note for this edge.
        /// </summary>
        /// <value>The note.</value>
        public string Note { get; set; }

        /// <summary>
        /// Identifier of the counter edge that relates Related to Primary.
        /// </summary>
        /// <value>The counter edge identifier.</value>
        public Guid? CounterEdgeId { get; set; }
    }
}
