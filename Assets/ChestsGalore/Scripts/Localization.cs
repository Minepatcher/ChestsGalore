using System.Collections.Generic;
using CoreLib.Localization;

namespace ChestsGalore.Scripts
{
    public class Localization
    {
        public static void LocalizeAllTerms()
        {
            // Items and Descriptions
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchChest", new Dictionary<string, string>
            {
                { "de", "Truhenwerkbank" },
                { "en", "Chest Workbench" },
                { "es", "Mesa de trabajo del cofre" },
                { "fr-FR", "Établi coffre" },
                { "it-IT", "Banco da lavoro a forziere" },
                { "ja", "宝箱の作業台" },
                { "pt-BR", "Bancada de Baú" },
                { "ko", "상자 작업대" },
                { "ru", "Сундук Верстак" },
                { "th", "โต๊ะทำงานแบบหีบ" },
                { "uk", "Скриня Верстак" },
                { "zh-CN", "箱子工作台" },
                { "zh-TW", "箱子工作台" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchChestDesc", new Dictionary<string, string>
            {
                { "de", "Erstellt alle Basistruhen" },
                { "en", "Creates All Basic Chests" },
                { "es", "Crea todos los cofres básicos" },
                { "fr-FR", "Crée tous les coffres de base" },
                { "it-IT", "Crea tutti i forzieri base" },
                { "ja", "すべての基本チェストを作成します" },
                { "pt-BR", "Cria todos os baús básicos" },
                { "ko", "모든 기본 상자를 생성합니다" },
                { "ru", "Создает все базовые сундуки" },
                { "th", "สร้างหีบพื้นฐานทั้งหมด" },
                { "uk", "Створює всі базові скрині" },
                { "zh-CN", "创建所有基本箱子" },
                { "zh-TW", "創建所有基本箱子" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchDoubleChest", new Dictionary<string, string>
            {
                { "de", "Doppelte Truhenwerkbank" },
                { "en", "Double Chest Workbench" },
                { "es", "Mesa de trabajo de doble cofre" },
                { "fr-FR", "Établi à double coffre" },
                { "it-IT", "Banco da lavoro a doppia forziere" },
                { "ja", "大きな宝箱の作業台" },
                { "pt-BR", "Bancada de Baú Duplo" },
                { "ko", "대형 상자 작업대" },
                { "ru", "большой сундук верстак" },
                { "th", "โต๊ะทำงานหีบคู่" },
                { "uk", "Великий Скриня Верстак" },
                { "zh-CN", "双箱工作台" },
                { "zh-TW", "雙箱工作台" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchDoubleChestDesc", new Dictionary<string, string>
            {
                { "de", "Erzeugt doppelte Truhen" },
                { "en", "Creates Double Chests" },
                { "es", "Crea cofres dobles" },
                { "fr-FR", "Crée des coffres doubles" },
                { "it-IT", "Crea doppi forzieri" },
                { "ja", "ダブルチェストを作成する" },
                { "pt-BR", "Cria Baús Duplos" },
                { "ko", "모든 대형 상자를 생성합니다" },
                { "ru", "Создавайте большие сундуки" },
                { "th", "สร้างหีบคู่" },
                { "uk", "Створює великі скрині" },
                { "zh-CN", "创建双箱" },
                { "zh-TW", "創建雙箱" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchDoubleChestExtra", new Dictionary<string, string>
            {
                { "de", "Doppelte Truhenwerkbank" },
                { "en", "Double Chest Workbench" },
                { "es", "Banco de trabajo del doble cofre" },
                { "fr-FR", "Établi à double coffre" },
                { "it-IT", "Banco da lavoro a doppia forziere" },
                { "ja", "大きな宝箱の作業台" },
                { "pt-BR", "Bancada de Baú Duplo" },
                { "ko", "대형 상자 작업대" },
                { "ru", "большой сундук верстак" },
                { "th", "โต๊ะทำงานหีบคู่" },
                { "uk", "Великий Скриня Верстак" },
                { "zh-CN", "双箱工作台" },
                { "zh-TW", "雙箱工作台" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchDoubleChestExtraDesc", new Dictionary<string, string>
            {
                { "de", "Erzeugt doppelte Truhen" },
                { "en", "Creates Double Chests" },
                { "es", "Crea cofres dobles" },
                { "fr-FR", "Crée des coffres doubles" },
                { "it-IT", "Crea doppi forzieri" },
                { "ja", "ダブルチェストを作成する" },
                { "pt-BR", "Cria Baús Duplos" },
                { "ko", "모든 대형 상자를 생성합니다" },
                { "ru", "Создавайте большие сундуки" },
                { "th", "สร้างหีบคู่" },
                { "uk", "Створює великі скрині" },
                { "zh-CN", "创建双箱" },
                { "zh-TW", "創建雙箱" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchMagicChest", new Dictionary<string, string>
            {
                { "de", "Magische Truhenwerkbank" },
                { "en", "Magic Chest Workbench" },
                { "es", "Banco de trabajo del cofre mágico" },
                { "fr-FR", "Établi de coffre magique" },
                { "it-IT", "Banco da lavoro a magico forziere" },
                { "ja", "魔法のチェスト作業台" },
                { "pt-BR", "Bancada de Baú Mágico" },
                { "ko", "마법 상자 작업대" },
                { "ru", "волшебный Сундук Верстак" },
                { "th", "โต๊ะทำงานหีบวิเศษ" },
                { "uk", "Чарівна Скриня Верстак" },
                { "zh-CN", "魔法箱工作台" },
                { "zh-TW", "魔法箱工作台" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:WorkbenchMagicChestDesc", new Dictionary<string, string>
            {
                { "de", "Erzeugt magisch erweiterte Truhen" },
                { "en", "Creates Magically Expanded Chests" },
                { "es", "Crea cofres expandidos mágicamente" },
                { "fr-FR", "Crée des coffres magiquement agrandis" },
                { "it-IT", "Crea forzieri magicamente espansi" },
                { "ja", "魔法的に拡張されたチェストを作成する" },
                { "pt-BR", "Cria baús magicamente expandidos" },
                { "ko", "마법으로 확장된 상자를 생성합니다" },
                { "ru", "Создает магически расширенные сундуки" },
                { "th", "สร้างหีบขยายอย่างมหัศจรรย์" },
                { "uk", "Створює магічно розширені скрині" },
                { "zh-CN", "创造魔法扩大的箱子" },
                { "zh-TW", "創造魔法擴大的箱子" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:MagicChest", new Dictionary<string, string>
            {
                { "de", "Magische Truhe" },
                { "en", "Magic Chest" },
                { "es", "Cofre Mágico" },
                { "fr-FR", "Coffre magique" },
                { "it-IT", "Forziere magica" },
                { "ja", "魔法の宝箱" },
                { "pt-BR", "Baú Mágico" },
                { "ko", "마법 상자" },
                { "ru", "Волшебный Сундук" },
                { "th", "หีบวิเศษ" },
                { "uk", "Чарівна Скриня" },
                { "zh-CN", "魔法箱子" },
                { "zh-TW", "魔法箱子" }
            });
            LocalizationModule.AddTerm("Items/ChestsGalore:MagicChestDesc", new Dictionary<string, string>
            {
                { "de", "Deine harte Arbeit hat sich endlich ausgezahlt und du hast eine kompakte Truhe von unglaublicher Größe gebaut!\n" +
                        "Moment mal ... ich glaube, damit kann man auch Dinge antreiben?" },
                { "en", "Your hard work has finally paid off and you have made a compact chest of incredible size!\n" +
                        "Wait...I think it can power things as well?" },
                { "es", "¡Tu esfuerzo finalmente dio sus frutos y has creado un cofre compacto de un tamaño increíble!\n" +
                        "Espera... ¿creo que también puede alimentar cosas?" },
                { "fr-FR", "Votre travail acharné a finalement porté ses fruits : vous avez fabriqué un coffre compact d'une taille incroyable!\n" +
                           "Attendez… Je crois qu'il peut aussi alimenter des appareils électriques?" },
                { "it-IT", "Il tuo duro lavoro è stato finalmente ripagato e hai creato un forziere compatta di dimensioni incredibili!\n" +
                           "Aspetta...penso che possa anche alimentare altre cose?" },
                { "ja", "努力が報われ、ついに信じられないほど大きなコンパクトなチェストが完成しました！\n" +
                        "えっと…これって何かに電力を供給できるのかな？" },
                { "pt-BR", "Seu trabalho duro finalmente valeu a pena e você fez um baú compacto de tamanho incrível!\n" +
                           "Espera... Acho que ele também dá energia para outras coisas?" },
                { "ko", "드디어 노고가 결실을 맺어 믿을 수 없을 만큼 큰 컴팩트한 상자를 만드셨네요!\n" +
                        "잠깐...혹시 물건도 넣을 수 있을까요?" },
                { "ru", "Твои труды наконец-то окупились, и ты сделал компактный сундук невероятного размера!\n" +
                        "Подожди...Разве он не может ещё и питать что-то?" },
                { "th", "ในที่สุดความพยายามของคุณก็เห็นผลแล้ว คุณได้สร้างหีบใบจิ๋วกะทัดรัดนี้ขึ้นมาได้!\n" +
                        "เดี๋ยวนะ...ฉันว่ามันให้พลังงานกับอะไรได้ด้วยนะ?" },
                { "uk", "Ваша наполеглива праця нарешті окупилася, і ви зробили компактну скриню неймовірних розмірів!\n" +
                        "Зачекайте...Я думаю, що вона також може живити речі?" },
                { "zh-CN", "你的辛勤劳动终于有了回报，你做出了一个尺寸惊人的紧凑型箱子！\n" +
                           "等等…我觉得它也能给东西供电？" },
                { "zh-TW", "你的辛勤工作終於有了回報，你做出了一個尺寸驚人的緊湊型箱子！\n" +
                           "等等…我覺得它也能給東西供電？" }
            });
            
            // Workbench Titles
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchChestTextLeft", new Dictionary<string, string>
            {
                { "de", "Einfache\nTruhen" },
                { "en", "Basic\nChests" },
                { "es", "Cofres\nBásicos" },
                { "fr-FR", "Coffres\nBase" },
                { "it-IT", "Forzieri\nBase" },
                { "ja", "基本\nチェスト" },
                { "pt-BR", "Baús\nBásicos" },
                { "ko", "기본\n상자" },
                { "ru", "Базовые\nСундуки" },
                { "th", "หีบพื้นฐาน" },
                { "uk", "Базові\nСкрині" },
                { "zh-CN", "基本\n箱子" },
                { "zh-TW", "基本\n箱子" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchChestTextCenter", new Dictionary<string, string>
            {
                { "de", "Erweiterte\nTruhen" },
                { "en", "Advanced\nChests" },
                { "es", "Cofres\nAvanzados" },
                { "fr-FR", "Coffres\nAvancés" },
                { "it-IT", "Forzieri\nAvanzati" },
                { "ja", "上級\nチェスト" },
                { "pt-BR", "Baús\nAvançados" },
                { "ko", "고급\n상자" },
                { "ru", "Современный\nСундуки" },
                { "th", "หีบขั้นสูง" },
                { "uk", "Сучасна\nСкрині" },
                { "zh-CN", "高级\n箱子" },
                { "zh-TW", "高級\n箱子" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchChestTextRight", new Dictionary<string, string>
            {
                { "de", "Spezial\nTruhen" },
                { "en", "Special\nChests" },
                { "es", "Cofres\nEspeciales" },
                { "fr-FR", "Coffres\nSpéciaux" },
                { "it-IT", "Forzieri\nSpeciali" },
                { "ja", "特別\nチェスト" },
                { "pt-BR", "Baús\nEspeciais" },
                { "ko", "특별\n상자" },
                { "ru", "Специальные\nСундуки" },
                { "th", "หีบพิเศษ" },
                { "uk", "Спеціальні\nСкрині" },
                { "zh-CN", "特殊\n箱子" },
                { "zh-TW", "特殊\n箱子" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestTextLeft", new Dictionary<string, string>
            {
                { "de", "Schleim\nBosse" },
                { "en", "Slime\nBosses" },
                { "es", "Jefes\nBabas" },
                { "fr-FR", "Boss\nSlime" },
                { "it-IT", "Boss\nMelma" },
                { "ja", "スライム\nボス" },
                { "pt-BR", "Chefes\nSlime" },
                { "ko", "슬라임\n보스" },
                { "ru", "Слайм\nбоссы" },
                { "th", "สไลม์บอส" },
                { "uk", "Слизові\nбоси" },
                { "zh-CN", "史莱姆\nBoss" },
                { "zh-TW", "史萊姆\nBoss" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestTextCenter", new Dictionary<string, string>
            {
                { "de", "Insekten\nBosse" },
                { "en", "Insect\nBosses" },
                { "es", "Jefes\nInsectos" },
                { "fr-FR", "Boss\nInsectes" },
                { "it-IT", "Boss\nInsetti" },
                { "ja", "昆虫\nボス" },
                { "pt-BR", "Chefes\nInsetos" },
                { "ko", "곤충\n보스" },
                { "ru", "насекомых\nБоссы" },
                { "th", "บอสแมลง" },
                { "uk", "Комахи\nбоси" },
                { "zh-CN", "昆虫\nBoss" },
                { "zh-TW", "昆蟲\nBoss" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestTextRight", new Dictionary<string, string>
            {
                { "de", "Titan\nBosse" },
                { "en", "Titan\nBosses" },
                { "es", "Jefes\nTitanes" },
                { "fr-FR", "Boss\nTitans" },
                { "it-IT", "Boss\nTitano" },
                { "ja", "巨大\nボス" },
                { "pt-BR", "Chefes\nTitãs" },
                { "ko", "거인\n보스" },
                { "ru", "Титанов\nБоссы" },
                { "th", "บอสยักษ์" },
                { "uk", "Титанові\nбоси" },
                { "zh-CN", "泰坦\nBoss" },
                { "zh-TW", "泰坦\nBoss" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestExtraTextLeft", new Dictionary<string, string>
            {
                { "de", "Grottling\nBosse" },
                { "en", "Caveling\nBosses" },
                { "es", "Jefes\nCavernícolas" },
                { "fr-FR", "Boss\nCaverneux" },
                { "it-IT", "Boss\nCavernicoli" },
                { "ja", "ケイヴリング\nボス" },
                { "pt-BR", "Chefes\nCavernoso" },
                { "ko", "동굴인\n보스" },
                { "ru", "Пещерник\nБоссы" },
                { "th", "บอสมนุษย์ถ้ำ" },
                { "uk", "Печерні\nбоси" },
                { "zh-CN", "穴居者\nBoss" },
                { "zh-TW", "洞穴人\nBoss" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestExtraTextCenter", new Dictionary<string, string>
            {
                { "de", "Lustiger\nFehler" },
                { "en", "Funny\nError" },
                { "es", "Error\nGracioso" },
                { "fr-FR", "Erreur\nAmusante" },
                { "it-IT", "Errore\nDivertente" },
                { "ja", "面白い\nエラー" },
                { "pt-BR", "Erro\nEngraçado" },
                { "ko", "웃긴\n오류" },
                { "ru", "Смешная\nОшибка" },
                { "th", "ข้อผิดพลาดตลกๆ" },
                { "uk", "Смішна\nПомилка" },
                { "zh-CN", "有趣的错误" },
                { "zh-TW", "有趣的錯誤" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchDoubleChestExtraTextRight", new Dictionary<string, string>
            {
                { "de", "Kern\nBosse" },
                { "en", "Core\nBosses" },
                { "es", "Jefes\nNúcleos" },
                { "fr-FR", "Boss\nNoyaux" },
                { "it-IT", "Boss\nNuclei" },
                { "ja", "コア\nボス" },
                { "pt-BR", "Chefes\nNúcleos" },
                { "ko", "코어\n보스" },
                { "ru", "Ядра\nБоссы" },
                { "th", "บอสแกนกลาง" },
                { "uk", "Ядра\nбоси" },
                { "zh-CN", "核心\nBoss" },
                { "zh-TW", "核心\nBoss" }
            });
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchMagicChestTextCenter", new Dictionary<string, string>
            {
                { "de", "Magische\nTruhen" },
                { "en", "Magic\nChests" },
                { "es", "Cofres\nMágicos" },
                { "fr-FR", "Coffres\nMagiques" },
                { "it-IT", "Forzieri\nMagici" },
                { "ja", "魔法の宝箱" },
                { "pt-BR", "Baús\nMágicos" },
                { "ko", "마법\n상자" },
                { "ru", "Волшебные\nсундуки" },
                { "th", "หีบวิเศษ" },
                { "uk", "Чарівні\nскрині" },
                { "zh-CN", "魔法\n箱子" },
                { "zh-TW", "魔法\n箱子" }
            });
            //Next Workbench Title
            LocalizationModule.AddTerm("ChestsGalore/WorkbenchChestNextTextCenter", new Dictionary<string, string>
            {
                { "de", "Nächste\nWerkbank" },
                { "en", "Next\nWorkbench" },
                { "es", "Próximo Mesa de Trabajo" },
                { "fr-FR", "Prochain\nÉtabli" },
                { "it-IT", "Prossimo Banco da Lavoro" },
                { "ja", "次の作業台" },
                { "pt-BR", "Próxima Bancada de Trabalho" },
                { "ko", "다음\n작업대" },
                { "ru", "Следующий\nверстак" },
                { "th", "โต๊ะทำงานถัดไป" },
                { "uk", "Наступний\nверстак" },
                { "zh-CN", "下一个\n工作台" },
                { "zh-TW", "下一個\n工作台" }
            });
            
            //Creative UI Item Categories
            LocalizationModule.AddTerm("ItemCategory/ChestsGalore", new Dictionary<string, string>
            {
                { "de", "Truhen in Hülle und Fülle" },
                { "en", "Chests Galore" },
                { "es", "Cofres En Abundancia" },
                { "fr-FR", "Des Coffres à Profusion" },
                { "it-IT", "Forzieri a Bizzeffe" },
                { "ja", "チェストがいっぱい" },
                { "pt-BR", "Baús em Abundância" },
                { "ko", "상자가 넘쳐난다" },
                { "ru", "Сундуки в изобилии" },
                { "th", "หีบมากมาย" },
                { "uk", "Скрині вдосталь" },
                { "zh-CN", "很多箱子" },
                { "zh-TW", "很多箱子" }
            });
            LocalizationModule.AddTerm("ItemCategory/ChestsGalore_Workbench", new Dictionary<string, string>
            {
                { "de", "Werkbank" },
                { "en", "Workbench" },
                { "es", "Mesa de Trabajo" },
                { "fr-FR", "Établi" },
                { "it-IT", "Banco da lavoro" },
                { "ja", "作業台" },
                { "pt-BR", "Bancada" },
                { "ko", "작업대" },
                { "ru", "верстак" },
                { "th", "โต๊ะทำงาน" },
                { "uk", "верстак" },
                { "zh-CN", "工作台" },
                { "zh-TW", "工作台" }
            });
            LocalizationModule.AddTerm("ItemCategory/ChestsGalore_Chest", new Dictionary<string, string>
            {
                { "de", "Kiste" },
                { "en", "Chest" },
                { "es", "Cofre" },
                { "fr-FR", "Coffre" },
                { "it-IT", "Forziere" },
                { "ja", "宝箱" },
                { "pt-BR", "Baú" },
                { "ko", "상자" },
                { "ru", "сундук" },
                { "th", "หีบ" },
                { "uk", "скриня" },
                { "zh-CN", "箱子" },
                { "zh-TW", "箱子" }
            });
        }
    }
}