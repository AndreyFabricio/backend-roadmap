   M S B A M L   `   `   `  ���� I  EWPF Calculator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WPF_CalculatorWPF_Calculator      WPF_Calculator.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     .localclr-namespace:WPF_Calculator     -     �Name$  WPF_Calculator�� � Title$ WPF Calculator��$��Stretch=�$��Stretch=� � WindowStyle$ SingleBorderWindow=� J� OpacityMask �	#FF101011���	#FF0D0D0E � 
ResizeMode$ NoResize=� � SizeToContent$ WidthAndHeight=�$��Stretch=�$��Stretch=�$	��280�� � WindowStartupLocation$ CenterScreen=� � Topmost$
 True��$	��260�� � Icon$ /calculator.png��$	��420��	 � 	Resources	    FocusVisual
 �� Property �� Value �� StrokeDashArray J� SnapsToDevicePixels  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 ButtonStyle1 �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 R     &	 g     &	 |     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7  7  7  7  7 	 �� .��� 
 � �� �� .R��� $��2q�$	 1 2R�$
 true��$��1��#��� ���� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FF191E21���� $ 	#FFBBBBBB���� $ 	#FF3D3D3E���� $ 	#FFBBBBBB���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� " ��.��� 
 �@�FocusVisualStyle8   �� 
 � ��8  �� 
 � ��8  �� 
 � ��# � ���� 
 � ��$ 1q��� 
 � ��$ Center=��� 
 � ��$ Center=��� 
 � ��$ 1q��� 
 � �� �� " ��.R��� $ border��#��z��#��z��#��z��$
 true��._��� $ contentPresenter��$|�False��#��z��#��z��$
��True��# z #��z�� P�  �@��IsDefaulted$
 true��. ��� $ border��# � ��
 � ��P�  �@J�IsMouseOver$
 true��. ��� $ border��8  
 � ���� $ border��8  
 � ��P�  � ��$
 true��. ��� $ border��8  
 � ���� $ border��8  
 � ��P�  � {�$ false��. ��� $ border��8  
 � ���� $ border��8  
 � ���� $ contentPresenter��8 	 
 � ��.��� $	��340��$��Stretch=�$��5,5,5,5q� � RowDefinitions �� $��40 ��� $��60 ��� $
��Auto � � ColumnDefinitions �� $
��Auto �.+��� -    ��Name$ label2��$�� ��$��0,0,0,0q�$��Bottom=�$��Stretch=�$��Stretch=�$��28(�$��DemiBold"����	#FFBBBBBB$��Right=��� -   $ label1��$�� ��$��0,0,0,5q�$��Bottom=�$��Stretch=�$��Stretch=�$��42(�$��DemiBold"����	#FFBBBBBB$��Right=�$��1��$��0,0,0,0q�� $��2��$��0,0,0,0q�$	��260��$	��240�� �� $
��Auto �$��20���� $
��Auto �$��20���� $
��Auto �$��20���� $
��Auto �$��20�� �� $
��Auto �$��20���� $
��Auto �$��20���� $
��Auto �$��20���� $
��Auto �$��20���� $
��Auto �$��20���� $
��Auto �$��20��.+��� -    ��Name$ 
btnPercent��$��0��$��0��#��� 
 $��%��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ btnRoot��$��1��$��0��#��� 
 $	��√��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ 	btnSquare��$��2��$��0��#��� 
 $	��x²��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ 
btnDecimal��$��3��$��0��#��� 
 $	��1/x��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ btnClear��$��0��$��1��#��� 
 $��CE��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -	   $ btnReset��$��1��$��1��#��� 
 $��C��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -
   $ btnDel��$��2��$��1��#��� 
 $	��DEL��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ 	btnDivide��$��3��$��1��#��� 
 $��÷��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn7��$��0��$��2��#��� 
 $��7��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn8��$��1��$��2��#��� 
 $��8��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn9��$��2��$��2��#��� 
 $��9��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ btnMultiply��$��3��$��2��#��� 
 $��X��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn4��$��0��$��3��#��� 
 $��4��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn5��$��1��$��3��#��� 
 $��5��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn6��$��2��$��3��#��� 
 $��6��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ btnSubtract��$��3��$��3��#��� 
 $��-��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn1��$��0��$��4��#��� 
 $��1��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn2��$��1��$��4��#��� 
 $��2��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn3��$��2��$��4��#��� 
 $��3��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ btnAdd��$��3��$��4��#��� 
 $��+��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ 	btnPosNeg��$��0��$��5��#��� 
 $��±��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $
 btn0��$��1��$��5��#��� 
 $��0��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF0D0D0E���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ btnDot��$��2��$��5��#��� 
 $��,��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(��� -   $ 	btnEquals��$��3��$��5��#��� 
 $��=��$��Stretch=�$��0,0,0,0q�$��Stretch=�$��1��$��1��$��Center=�$��Center=�$��0,0,0,0q�$��SemiBold"����	#FFBBBBBB���	#FF30363C���	#FF2E2E2E$��65��$��40��$��65��$��40��$��20(�