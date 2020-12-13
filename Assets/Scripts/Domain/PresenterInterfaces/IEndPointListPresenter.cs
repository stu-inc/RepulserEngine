﻿using System;
using System.Collections.Generic;
using ProjectBlue.RepulserEngine.Domain.Model;
using UniRx;

namespace ProjectBlue.RepulserEngine.Presentation
{
    public interface IEndPointListPresenter
    {
        IEnumerable<EndpointSetting> EndpointSettingList { get; }
    }

    public interface IPulseSettingListPresenter
    {
        IEnumerable<PulseSetting> PulseSettingList { get; }
        IObservable<Unit> OnSaveButtonClickedAsObservable { get; }

        void SetData(IEnumerable<PulseSetting> settingList);
    }
}