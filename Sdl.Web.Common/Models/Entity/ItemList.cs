﻿using System.Collections.Generic;

namespace Sdl.Web.Common.Models
{
    [SemanticEntity(Vocab = SchemaOrgVocabulary, EntityName = "ItemList", Prefix = "s", Public = true)]
    public class ItemList : EntityModel
    {
        [SemanticProperty("s:headline")]
        public string Headline { get; set; }
        [SemanticProperty("s:itemListElement")]
        public List<Teaser> ItemListElements { get; set; }
    }
}
