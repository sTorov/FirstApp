﻿/*
 * Ассоциация — это отношение, при котором объекты одного типа неким образом
 * связаны с объектами другого типа. Объект одного типа может содержать или 
 * использовать объект другого типа.
 * 
 * В виде UML-диаграмм такое отношение отражается обычной стрелкой
 */

class MotherBoard
{
}

class SystemUnit
{
    private MotherBoard motherBoard;
}