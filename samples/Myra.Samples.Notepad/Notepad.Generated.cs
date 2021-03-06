/* Generated by Myra UI Editor at 22.02.2019 1:06:12 */

#if !XENKO
using Microsoft.Xna.Framework;
#else
#endif

using Myra.Graphics2D.UI;

namespace Myra.Samples.Notepad
{
	partial class Notepad
	{
		private void BuildUI()
		{
			menuItemNew = new MenuItem();
			menuItemNew.Id = "menuItemNew";
			menuItemNew.Text = "New";

			menuItemOpen = new MenuItem();
			menuItemOpen.Id = "menuItemOpen";
			menuItemOpen.Text = "Open...";

			menuItemSave = new MenuItem();
			menuItemSave.Id = "menuItemSave";
			menuItemSave.Text = "Save";

			menuItemSaveAs = new MenuItem();
			menuItemSaveAs.Id = "menuItemSaveAs";
			menuItemSaveAs.Text = "Save As...";

			var menuSeparator1 = new MenuSeparator();

			menuItemDebugOptions = new MenuItem();
			menuItemDebugOptions.Id = "menuItemDebugOptions";
			menuItemDebugOptions.Text = "Debug Options";

			var menuSeparator2 = new MenuSeparator();

			menuItemQuit = new MenuItem();
			menuItemQuit.Id = "menuItemQuit";
			menuItemQuit.Text = "Quit";

			menuItemFile = new MenuItem();
			menuItemFile.Id = "menuItemFile";
			menuItemFile.Text = "File";
			menuItemFile.Items.Add(menuItemNew);
			menuItemFile.Items.Add(menuItemOpen);
			menuItemFile.Items.Add(menuItemSave);
			menuItemFile.Items.Add(menuItemSaveAs);
			menuItemFile.Items.Add(menuSeparator1);
			menuItemFile.Items.Add(menuItemDebugOptions);
			menuItemFile.Items.Add(menuSeparator2);
			menuItemFile.Items.Add(menuItemQuit);

			menuItemAbout = new MenuItem();
			menuItemAbout.Id = "menuItemAbout";
			menuItemAbout.Text = "About";

			menuItemHelp = new MenuItem();
			menuItemHelp.Id = "menuItemHelp";
			menuItemHelp.Text = "Help";
			menuItemHelp.Items.Add(menuItemAbout);

			mainMenu = new HorizontalMenu();
			mainMenu.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			mainMenu.Id = "mainMenu";
			mainMenu.Items.Add(menuItemFile);
			mainMenu.Items.Add(menuItemHelp);

			var horizontalSeparator1 = new HorizontalSeparator();
			horizontalSeparator1.Height = 4;
			horizontalSeparator1.GridRow = 1;

			textArea = new TextField();
			textArea.Text = "";
			textArea.Wrap = true;
			textArea.Multiline = true;
			textArea.Id = "textArea";
			textArea.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;

			var scrollPane1 = new ScrollPane();
			scrollPane1.GridRow = 2;
			scrollPane1.Child = textArea;

			
			RowsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			Id = "Root";
			Widgets.Add(mainMenu);
			Widgets.Add(horizontalSeparator1);
			Widgets.Add(scrollPane1);
		}

		
		public MenuItem menuItemNew;
		public MenuItem menuItemOpen;
		public MenuItem menuItemSave;
		public MenuItem menuItemSaveAs;
		public MenuItem menuItemDebugOptions;
		public MenuItem menuItemQuit;
		public MenuItem menuItemFile;
		public MenuItem menuItemAbout;
		public MenuItem menuItemHelp;
		public HorizontalMenu mainMenu;
		public TextField textArea;
	}
}