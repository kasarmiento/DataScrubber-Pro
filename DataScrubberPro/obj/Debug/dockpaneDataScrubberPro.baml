   M S B A M L   `   `   `  ����J  FDataScrubberPro, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DataScrubberProDataScrubberPro  5      U QArcGIS.Desktop.Extensions, Version=11.4.0.0, Culture=neutral, PublicKeyToken=nullhJclr-namespace:ArcGIS.Desktop.Extensions;assembly=ArcGIS.Desktop.ExtensionsArcGIS.Desktop.Extensions 5      1    +DataScrubberPro.dockpaneDataScrubberProView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      &uiclr-namespace:DataScrubberPro  5      [
extensionsJclr-namespace:ArcGIS.Desktop.Extensions;assembly=ArcGIS.Desktop.Extensions  5        � 	Resources  5       �� MergedDictionaries<  6ArcGIS.Desktop.Extensions.DesignOnlyResourceDictionary   Source�� 5   
    5        5      $S Mpack://application:,,,/ArcGIS.Desktop.Framework;component\Themes\Default.xaml?�6:   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $��* �6   .+�5&   
   ]� $��0��6   ��. -  'System.Windows.Input.KeyboardNavigation   TabNavigation$ Local=�66   $��30��6_   .+�5'      �� $��Center=�61   $��Center=�5(      $��16(�65   $��Light"�6C   ��5'      �� *	Heading+ � ToolTip 5)      � 5*       � Orientation$ Vertical=�6    $	��300��67   .+�5+      �� $
��Wrap=�6=   ��6$   �� *	Heading+6=   5,      5.      5/   	   �� 51   
   $��1��6    �� Orientation$ Vertical=�6"   .+�52      �� $��Select your data��6   $��5q�60   �� 53      -   5        $��LayersComboBox��58      $��center=�53      $	��Top=�54      $��5q�55      $	��270��56      ��57      �� *Layers+ �� SelectedItem 59      �� *SelectedLayer+.  (System.Windows.Interactivity.Interaction	   Triggers	 5:      /  )System.Windows.Interactivity.EventTrigger  5;      
   	EventName$
 DropDownOpened��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5<      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *CmdDropDownLayers+5=      5?      5@      �� 5C   
   $��2��6   $ Vertical=�6"   .+�5D      �� $��DataScrubber Type��6   $��5q�61   �� 5E      -   5        $��ScrubberTypesComboBox��5J      $��Center=�5E      $	��Top=�5F      $��5q�5G      $��270px��5H      ��5I      �� *StrubberTypes+5J      5K      �� 5M   
   $��5��6   $ 
Horizontal=�6"   $��Center=�6;   .+�5N      �� $��Validate Data��6   $��10,5,0,5q�5O      $��Center=�5P      $	��Top=�5Q      $
��Auto��5R         Esri_SimpleButton#���   5T      ��5S      �� *
CmdScrub+5T   C   5U      5W      5X      