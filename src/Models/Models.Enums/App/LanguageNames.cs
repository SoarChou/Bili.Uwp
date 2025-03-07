﻿// Copyright (c) Richasy. All rights reserved.

namespace Richasy.Bili.Models.Enums
{
    /// <summary>
    /// Localized text resource name.
    /// </summary>
    public enum LanguageNames
    {
#pragma warning disable SA1602 // Enumeration items should be documented
        AppName,
        AppDescription,
        Confirm,
        Cancel,
        Navigation,
        Popular,
        Rank,
        Partition,
        SpecialColumn,
        Live,
        Personal,
        DynamicFeed,
        MyFavorite,
        ViewLater,
        ViewHistory,
        HelpAndSupport,
        PartitionLoading,
        Recommend,
        TenThousands,
        Billion,
        Hours,
        Minutes,
        Seconds,
        ComprehensiveDynamics,
        SelectSortType,
        SortByDefault,
        SortByNewest,
        SortByPlay,
        SortByReply,
        SortByDanmaku,
        SortByFavorite,
        SortByLike,
        SortByRead,
        SearchTip,
        SearchTipSlim,
        SignInTitle,
        UserName,
        Password,
        SignIn,
        UserNameHolder,
        PasswordHolder,
        Captcha,
        CaptchaHolder,
        ValidUserNameOrPasswordTip,
        CaptchaIsEmpty,
        InputCaptchaTip,
        InvalidUserNameOrPassword,
        NeedQRLogin,
        PasswordLoginTip,
        QRLoginTip,
        SwitchToPasswordLogin,
        SwitchToQRLogin,
        Refresh,
        FailedToLoadQRCode,
        QRCodeExpired,
        LoginFailed,
        PleaseSignIn,
        Topic,
        Bangumi,
        DomesticAnime,
        Documentary,
        Movie,
        TV,
        SignOut,
        MyWebPage,
        Message,
        WholePartitions,
        Original,
        Rookie,
        Score,
        RankRequestFailed,
        PartitionRequestFailed,
        RequestRecommendFailed,
        RequestSubPartitionFailed,
        RequestPopularFailed,
        FollowLiveRoom,
        SeeAll,
        Total,
        CategoriesReuqestFailed,
        RequestArticleListFailed,
        RequestLiveFailed,
        RequestTabDetailFailed,
        RequestPgcFailed,
        ShowMore,
        Index,
        TimeChart,
        RequestFeedDetailFailed,
        AppTheme,
        AppThemeDescription,
        Generic,
        Light,
        Dark,
        FollowSystem,
        RestartWarning,
        StartMethod,
        StartMethodDescription,
        Prelaunch,
        PrelaunchDescription,
        Startup,
        StartupDescription,
        StartupDisabledByUser,
        StartupDisabledByPolicy,
        LoggerModule,
        LoggerModuleDescription,
        LoggerFolder,
        OpenFolder,
        CleanLogger,
        Clean,
        Player,
        PlayerMode,
        PlayerModeDescription,
        AutoPlayWhenLoaded,
        DefaultPlayerDisplayMode,
        Default,
        FullScreenMode,
        FullWindowMode,
        PlayerControl,
        PlayerControlDescription,
        Prefer4K,
        Prefer4KDescription,
        PreferCodec,
        PreferCodecDescription,
        SingleFastForwardAndRewindSpan,
        SingleFastForwardAndRewindSpanDescription,
        MTCControlMode,
        MTCControlModeDescription,
        Automatic,
        Manual,
        RequestVideoFailed,
        RelatedVideos,
        Like,
        Coin,
        Favorite,
        View,
        Danmaku,
        Share,
        Reply,
        H265,
        H264,
        Flv,
        CompactOverlayMode,
        ShowDanmaku,
        HideDanmaku,
        DanmakuPlaceholder,
        DanmakuSendSettings,
        DanmakuDisplaySettings,
        Parts,
        DanmakuOpacity,
        DanmakuZoom,
        DanmakuDensity,
        DanmakuFont,
        DanmakuMerge,
        UseCloudShieldSettings,
        Episodes,
        Seasons,
        Sections,
        Detail,
        PgcFollowing,
        PgcNotFollow,
        Chat,
        BackToDefaultView,
        DanmakuSwitch,
        HotSearch,
        FilterByTotalDuration,
        FilterByLessThan10Min,
        FilterByLessThan30Min,
        FilterByLessThan60Min,
        FilterByGreaterThan60Min,
        Videos,
        Search,
        SortByFansLTH,
        SortByFansHTL,
        SortByLevelHTL,
        SortByLevelLTH,
        TotalUser,
        UpMaster,
        OfficialUser,
        NormalUser,
        Followed,
        Follow,
        User,
        UserEmptySign,
        FansCount,
        FollowCount,
        BeLikeCount,
        UserHaveNoVideos,
        RequestUserInformationFailed,
        UserInformation,
        NoSpecificData,
        DanmakuStyle,
        Stroke,
        NoStroke,
        Shadow,
        DanmakuBold,
        PlayLine,
        Quality,
        Viewer,
        RequestLivePlayInformationFailed,
        NoMessage,
        NeedScaleToShowMessage,
        RequestHistoryFailed,
        Delete,
        PreviousView,
        DynamicCount,
        Vip,
        RequestFansFailed,
        FansSuffix,
        NoFans,
        RequestFollowsFailed,
        NoFollows,
        FollowsSuffix,
        RequestViewLaterFailed,
        ClearViewLater,
        NoViewLaterVideos,
        FailedToClearViewLater,
        FailedToRemoveVideoFromViewLater,
        Remove,
        AppTip,
        ClearViewLaterWarning,
        ClearHistory,
        FailedToRemoveVideoFromHistory,
        FailedToClearHisotry,
        NoHistoryVideos,
        ClearHistoryWarning,
        AddToViewLater,
        PlayCount,
        DanmakuCount,
        ReplyCount,
        ChooseCoinNumber,
        AlsoLike,
        ChooseFavorite,
        RequestFavoriteError,
        RequestIndexFilterFailed,
        PublishInInstalments,
        PublishFinished,
        RequestIndexResultFailed,
        Updated,
        NotUpdated,
        RequestPgcTimeLineFailed,
        RequestPlayListFailed,
        PeopleCount,
        OriginName,
        Alias,
        CastAndCrew,
        Description,
        RequestVideoFavoriteFailed,
        Anime,
        Cinema,
        DefaultFavorite,
        SeeDetail,
        VideoCount,
        FavoriteHaveNoVideos,
        RequestAnimeFavoriteFailed,
        RequestCinemaFavoriteFailed,
        RequestArticleFavoriteFailed,
        CollectTime,
        LikeCount,
        ReadCount,
        DeleteFavorite,
        UnFavorite,
        DeleteFavoriteWarning,
        UnFavoriteWarning,
        RefreshCurrentSection,
        RequestReplyFailed,
        MoreReplyDisplay,
        SortByHot,
        NeedScaleToShowReply,
        NoReply,
        HotReply,
        LastestReply,
        ReplyPlaceholderText,
        ReplyDetail,
        Top,
        ReplySomeone,
        AddReplyFailed,
        RequestDynamicFailed,
        RequestArticleFailed,
        DynamicNeedLoginFirst,
        Login,
        RequestMessageFailed,
        AtMe,
        ReplyMe,
        LikeMe,
        Lastest,
        LikeMessageMultipleDescription,
        LikeMessageSingleDescription,
        AtMessageTypeDescription,
        ReplyMessageTypeDescription,
        MorePeople,
        Standard,
        Small,
        FontSize,
        Location,
        ScrollDanmaku,
        TopDanmaku,
        BottomDanmaku,
        White,
        Red,
        Orange,
        Khaki,
        Yellow,
        Grass,
        Green,
        Blue,
        Purple,
        LightBlue,
        Color,
        IsNeedFeedback,
        IsNeedFeedbackDescription,
        AskIssue,
        BiliHomePage,
        ProjectHomePage,
        RelatedProjects,
        AddViewLaterSucceseded,
        AddViewLaterFailed,
        FollowRoom,
        FailedToGetUserRelation,
        NoRoomDescription,
        LogEmptied,
        FailedToClearLog,
        AboutThisApp,
        License,
        UnknownError,
        Aborted,
        NetworkError,
        DecodingError,
        SourceNotSupported,
        NoEpisode,
#pragma warning restore SA1602 // Enumeration items should be documented
    }
}
