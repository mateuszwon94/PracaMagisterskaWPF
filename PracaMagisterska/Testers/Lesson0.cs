﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace PracaMagisterska.WPF.Testers {
    /// <summary>
    /// Abstract class representing lesson zero
    /// </summary>
    public class Lesson0 : Lesson {
        /// <summary>
        /// Constructor.
        /// </summary>
        public Lesson0() : base(0, "Witaj Świecie", 0f) { }

        /// <inheritdoc cref="Tester.Solution"/>
        protected override object Solution(params object[] parameters) 
            => null;

        /// <inheritdoc cref="Tester.Solution"/>
        public override bool StaticTest(MethodDeclarationSyntax testMethod) 
            => true;

        /// <inheritdoc cref="Lesson.DefaultCode"/>
        public override string DefaultCode { get; } = defaultProgramWithMain_;

        /// <inheritdoc cref="Lesson.Info"/>
        public override string Info { get; } =
@"Oto twój pierwszy program. Przejdźmy linijka po linijce i wytłumacze Ci co się w nim dzieje.
W pierwszej linijce przy pomocy słowa kluczowego using importowana jest podstawowa biblioteka. W niej zanjdują się wszystkie najprostsze i najpotrzebniejsze typy typy.
Ponieważ C# jest czysto obiektowym językiem, to w linijce trzeciej zdefiniowana jest klasa (czy to dokładnie jest dowiesz się później). Ma ona w sobie metode Main. Tak nazywa się metodę, którą system operacyjny uruchamia jako pierwszą. W jej ciele z obiektu Console wywoływana jest metoda WriteLine, która wypisuje na ekran tekst z cudzysłowia.
Spróbuj skompilować i uruchomić ten program. Co zobaczyłeś w konsoli? Teraz spróbuj zmienić tekst i uruchomić program jeszcze raz.";

        /// <inheritdoc cref="Tester.ParametersType"/>
        protected override Type[] ParametersType { get; } = null;

        /// <inheritdoc cref="Lesson.RealTestCases"/>
        protected override List<object[]> RealTestCases { get; } = null;

        /// <inheritdoc cref="Lesson.SimpleTestCases"/>
        protected override List<object[]> SimpleTestCases { get; } = null;
    }
}