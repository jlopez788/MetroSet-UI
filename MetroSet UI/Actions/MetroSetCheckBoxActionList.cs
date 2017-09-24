﻿using MetroSet_UI.Controls;
using MetroSet_UI.Design;
using MetroSet_UI.Enums;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace MetroSet_UI.Tasks
{
    internal class MetroSetRadioButtonActionList : DesignerActionList
    {
        private readonly MetroSetRadioButton metroSetRadioButton;

        public MetroSetRadioButtonActionList(IComponent component) : base(component)
        {
            metroSetRadioButton = (MetroSetRadioButton)component;
        }

        public Style Style
        {
            get { return metroSetRadioButton.Style; }
            set { metroSetRadioButton.Style = value; }
        }

        public string ThemeAuthor
        {
            get { return metroSetRadioButton.ThemeAuthor; }
        }

        public string ThemeName
        {
            get { return metroSetRadioButton.ThemeName; }
        }

        public StyleManager StyleManager
        {
            get { return metroSetRadioButton.StyleManager; }
            set { metroSetRadioButton.StyleManager = value; }
        }

        public string Text
        {
            get { return metroSetRadioButton.Text; }
            set { metroSetRadioButton.Text = value; }
        }

        public bool Checked
        {
            get { return metroSetRadioButton.Checked; }
            set { metroSetRadioButton.Checked = value; }
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            DesignerActionItemCollection items = new DesignerActionItemCollection
        {
            new DesignerActionHeaderItem("MetroSet Framework"),
            new DesignerActionPropertyItem("StyleManager", "StyleManager", "MetroSet Framework", "Gets or sets the stylemanager for the control."),
            new DesignerActionPropertyItem("Style", "Style", "MetroSet Framework", "Gets or sets the style."),

            new DesignerActionHeaderItem("Informations"),
            new DesignerActionPropertyItem("ThemeName", "ThemeName", "Informations", "Gets or sets the The Theme name associated with the theme."),
            new DesignerActionPropertyItem("ThemeAuthor", "ThemeAuthor", "Informations", "Gets or sets the The Author name associated with the theme."),

            new DesignerActionHeaderItem("Appearance"),
            new DesignerActionPropertyItem("Text", "Text", "Appearance", "Gets or sets the The text associated with the control."),
            new DesignerActionPropertyItem("Checked", "Checked", "Appearance", "Gets or sets a value indicating whether the control is checked."),

        };

            return items;
        }
    }
}