﻿using pdfforge.PDFCreator.UI.Presentation.Helper.Translation;
using pdfforge.PDFCreator.UI.Presentation.ViewModelBases;
using pdfforge.PDFCreator.Utilities.Threading;
using System;
using Translatable;

namespace Presentation.UnitTest
{
    public class UnitTestTranslationUpdater : ITranslationUpdater
    {
        public void RegisterAndSetTranslation<T>(ITranslatableViewModel<T> model) where T : ITranslatable, new()
        {
            model.Translation = Activator.CreateInstance<T>();
        }

        public void RegisterAndSetTranslation(Action<ITranslationFactory> setTranslationAction)
        {
            setTranslationAction(new TranslationFactory());
        }

        public void CleanUp(object sender, ThreadFinishedEventArgs e)
        {
        }

        public void Clear()
        {
        }
    }
}
