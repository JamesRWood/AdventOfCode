namespace Tests
{
    using System.Collections.Generic;
    using Passphrases;
    using Xunit;

    public class Tests
    {
        private readonly PassphraseValidator _passphraseValidator;
        private readonly List<string> _inputPhrases;

        public Tests()
        {
            _passphraseValidator = new PassphraseValidator();
            _inputPhrases = new List<string>();
        }

        [Fact]
        public void Test()
        {
            _inputPhrases.Add("aa bb cc dd ee");
            RunTest(1);
        }

        [Fact]
        public void Test2()
        {
            _inputPhrases.Add("aa bb cc dd aa");
            RunTest(0);
        }

        [Fact]
        public void Test3()
        {
            _inputPhrases.Add("aa bb cc dd aaa");
            RunTest(1);
        }

        [Fact]
        public void Test_day4_1()
        {
            SetupData();
            RunTest(337);
        }

        [Fact]
        public void Test1_SecondHalf()
        {
            _inputPhrases.Add("abcde fghij");
            RunTest(1);
        }

        [Fact]
        public void Test2_SecondHalf()
        {
            _inputPhrases.Add("abcde xyz ecdab");
            RunTest(0);
        }

        [Fact]
        public void Test3_SecondHalf()
        {
            _inputPhrases.Add("a ab abc abd abf abj");
            RunTest(1);
        }

        [Fact]
        public void Test4_SecondHalf()
        {
            _inputPhrases.Add("iiii oiii ooii oooi oooo");
            RunTest(1);
        }

        [Fact]
        public void Test5_SecondHalf()
        {
            _inputPhrases.Add("oiii ioii iioi iiio");
            RunTest(0);
        }

        private void RunTest(int expected)
        {
            var result = _passphraseValidator.CountValidPassphrases(_inputPhrases);
            Assert.Equal(expected, result);
        }

        private void SetupData()
        {
            _inputPhrases.Add("kvvfl kvvfl olud wjqsqa olud frc");
            _inputPhrases.Add("slhm rdfm yxb rsobyt rdfm");
            _inputPhrases.Add("pib wzfr xyoakcu zoapeze rtdxt rikc jyeps wdyo hawr xyoakcu hawr");
            _inputPhrases.Add("ismtq qwoi kzt ktgzoc gnxblp dzfayil ftfx asscba ionxi dzfayil qwoi");
            _inputPhrases.Add("dzuhys kfekxe nvdhdtj hzusdy xzhehgc dhtvdnj oxwlvef");
            _inputPhrases.Add("gxg qahl aaipx tkmckn hcsuhy jsudcmy kcefhpn kiasaj tkmckn");
            _inputPhrases.Add("roan kqnztj edc zpjwb");
            _inputPhrases.Add("yzc roc qrygby rsvts nyijgwr xnpqz");
            _inputPhrases.Add("jqgj hhgtw tmychia whkm vvxoq tfbzpe ska ldjmvmo");
            _inputPhrases.Add("nyeeg omn geyen ngyee rcjt rjuxh");
            _inputPhrases.Add("qpq udci tnp fdfk kffd eyzvmg ufppf wfuodj toamfn tkze jzsb");
            _inputPhrases.Add("rrcgxyp rbufd tfjmok vpyhej hcnz ftkojm");
            _inputPhrases.Add("jnmomfc jnmomfc bkluz izn ovvm flsch bkluz");
            _inputPhrases.Add("odisl hzwv hiasrhi hez ihihsra qpbmi ltwjj iknkwxf nbdtq gbo");
            _inputPhrases.Add("gjtszl gjtszl fruo fruo");
            _inputPhrases.Add("rdapv gaik cqboix sxnizhh uxmpali jdd usqnz advrp dze");
            _inputPhrases.Add("flooz flooz qad tcrq yze bnoijff qpqu vup hyagwll");
            _inputPhrases.Add("lnazok dze foi tqwjsk hpx qcql euzpj mwfrk");
            _inputPhrases.Add("ilb fmviby ivybmf gtx xtg");
            _inputPhrases.Add("rpauuu timere gyg wcolt ireetm safi");
            _inputPhrases.Add("croe szwmq bbhd lciird vhcci pdax");
            _inputPhrases.Add("hnc ykswt qqqmei goe bri wmyai hnc qpgqc pberqf bzs");
            _inputPhrases.Add("hsnrb wdvh iezzrq iezzrq rdbmpta iezzrq kemnptg alkjnp wymmz");
            _inputPhrases.Add("ngw don ddvyds nlhkoa aaf gptumum ugtpmmu");
            _inputPhrases.Add("vmccke qbpag kvf kvf tgrfghb kvf bhpd sglgx");
            _inputPhrases.Add("obomgk bkcgo yso ttft vbw ckl wjgk");
            _inputPhrases.Add("fli qvw zhin dfpgfjb udsin nihz ovr tiewo");
            _inputPhrases.Add("tgmzmph hauzieo jmg tdbtl lvfr qpaayq qapaqy ausioeu jun piygx");
            _inputPhrases.Add("jkp guqrnx asdqmxf vmfvtqb tloqgyo ioix gajowri tmek ilc puhipb");
            _inputPhrases.Add("uycn zxqm znft ayal znacus kvcyd ekv qqfpnh");
            _inputPhrases.Add("fqghur xtbtdd ztjrylr bpuikb ziyk");
            _inputPhrases.Add("rvakn uqbl ozitpdh uqbl dsej xehj");
            _inputPhrases.Add("laxp haz jyd xnkrb ijldth woy xapl iqgg alpx gnupa ukptmmh");
            _inputPhrases.Add("dyiy dyiy ihb qcyxr");
            _inputPhrases.Add("wbwkd hdwu zvgkn hdwu wjc sakwhn zxujdo npllzp uyr uyr");
            _inputPhrases.Add("fxczpmn cininu akcxs ggslxr riyxe ojisxe");
            _inputPhrases.Add("ppbch sampq dnct afikor dnct edsqy pnzyzmc afikor");
            _inputPhrases.Add("jnvygtn hijqjxl vsd jnvygtn nqcqv zns odq gkboxrv kolnq wrvd");
            _inputPhrases.Add("mroq mroq flsbu flsbu");
            _inputPhrases.Add("fyshor xvpaunj qmktlo xoce wkiyfu ukcl srndc ugwylwm ozcwdw mtqcste kpokr");
            _inputPhrases.Add("cfh cxjvx cfh cfh uewshh");
            _inputPhrases.Add("bpspbap bpspbap fquj mxmn bwls iirhvuk dmpkyt exrn mxmn");
            _inputPhrases.Add("tvyvzk ezszod ntxr xtnr och");
            _inputPhrases.Add("knfxhy kbnyl knfxhy xhkssx lxru uprh nkxpbx oodolxr tpvyf");
            _inputPhrases.Add("nblmysu iwoffs upgof tyagwf aan vovji ajk ywzq oyfi sfulz");
            _inputPhrases.Add("aushzkm lcaeki mkuzsah ynxvte rsntd refk pcm");
            _inputPhrases.Add("mgguob gobmug dzenpty gmogbu");
            _inputPhrases.Add("yvq eepof rgnree nerger fpb stfrln ernger");
            _inputPhrases.Add("hrgkbl mzwvswk rsrsbk ieru holco pajvvn ztgsr qkyp fyeg owpcmoj");
            _inputPhrases.Add("fowda gmsqdca yugj mcrroxv mqcbojd fjnqfji qdfsc jqs");
            _inputPhrases.Add("qnc rvjfz vvxk sjd xrma ucdjvq sbw zydyt dfzww");
            _inputPhrases.Add("ocajazv cozaajv tqunkla udwf ecnnmbz lsakqg bki njnda zsdu ccfqw rxpc");
            _inputPhrases.Add("qqm qdfya qxyx qmq qfday uqnfttt");
            _inputPhrases.Add("rnbirb iapor qet iapor hxkhz dfvzig pedl ybyb");
            _inputPhrases.Add("mkgamxg xkniv meb hbzmxjn dhbj zhbxjmn hdjb");
            _inputPhrases.Add("ilteux pyutyfx mau lrr bacak");
            _inputPhrases.Add("sjjonmn dbbbgs crxyuu jztstgd ezb uiabyaa");
            _inputPhrases.Add("tra fle ufzlvf nnaw kec hiwnnlj tei wld iyt syk hjdczb");
            _inputPhrases.Add("qmd jtlud dgh dbanock fzp dsjgqru wwvo jwvxwgv xlemfij jcacd");
            _inputPhrases.Add("rpkx oxesil snazcgx fly miiyc ikmtmp oefyyn egbw");
            _inputPhrases.Add("ypfpeu wldnyd acchppb yqwcaw wldnyd turbz megci nbgxq xkc ypfpeu");
            _inputPhrases.Add("iqqv iqqv neui iqqv");
            _inputPhrases.Add("ypsxm icqyup zyetrwq nbisrv");
            _inputPhrases.Add("viommi toszx dpueq eyy cunjou ffcjc jaeez djefra pxvkj liudlig yye");
            _inputPhrases.Add("fhnacbg jghchh ghjhhc iue hwqmo");
            _inputPhrases.Add("vbjw lpn cizba ltnsfpz tzoweml irewlc uzckhpd mszal obd");
            _inputPhrases.Add("yeos utxkft hflxkfe fxczge qpgigkc ksgr vuumql vhlvv");
            _inputPhrases.Add("xzmkv xzmkv krecdi klpem jsbu nwcmik emfzxf cjmpgnj");
            _inputPhrases.Add("vtkjo pmiv zou gxo qdiyxsf hwyinjk jhkgf rjq");
            _inputPhrases.Add("dyuoc ywiyvch irfgl ywiyvch fxb fxb");
            _inputPhrases.Add("tuz onhr syu rqya abkaf bcfx mbknex juwoor zmksl");
            _inputPhrases.Add("oheg spjorx ksdy vwtq fxz phvtazk tcze lrxg");
            _inputPhrases.Add("hew lbup botaj ltr jpd");
            _inputPhrases.Add("dxgc tzinkej gnz hxvvub adsqmc dxgc asgpp rqbdcra goy pmamdua bhiacva");
            _inputPhrases.Add("xqv ygb kihxqz vyv pjcny vmyvsdv cgsi nfyx");
            _inputPhrases.Add("tqga ssshrw ndq qlbvwh huyd pxbgj qbxk dkkbf jxy chsobw pph");
            _inputPhrases.Add("hxl iwph iwph xnr otifm ljhre");
            _inputPhrases.Add("zlgvpd kapxpoc dve rklk ogh hgnp rbrmc zzkz hhmcx aklmo");
            _inputPhrases.Add("sar gfor nkf hek nkf aql shc aql");
            _inputPhrases.Add("dtcrw kfjzcjx qyhi bldson whwdayo mqtgt xhqzp ttqmg");
            _inputPhrases.Add("omspdml isze jdl nvwo qrkm wztfg ssfgyh dryj jhp unsmty");
            _inputPhrases.Add("jxt cszylng ifht ixtuna azoi xutqlv jtx tjx");
            _inputPhrases.Add("usgm azuayp fgkby ezpyq jqwl ezofj");
            _inputPhrases.Add("tnhvil nrvg moyrpqs sldx qymoff megflxh pyhqwms xmdw");
            _inputPhrases.Add("zomy zcquwnv lzx bvcna yods mjp dgsez");
            _inputPhrases.Add("blklyf xokd gpit tiysj yrwfhm tofx");
            _inputPhrases.Add("dtig vhdp omuj vhpd");
            _inputPhrases.Add("fogwxim qvdwig emdiv jvhl euwbzkg xvxb hwmqo ujdmlp epmykj");
            _inputPhrases.Add("sjxll sjxll pedvgb sjxll");
            _inputPhrases.Add("drvay gtzhgtx yrt okz nqf");
            _inputPhrases.Add("haxfazn pvkovwb pgu tgshw mxcjf pbe nwoymzc mxcjf pbe hydwy jradcr");
            _inputPhrases.Add("prjsloa ahylvj okbsj qbdcdjt pmfo pagyoeg vkmhjzt khzmjvt opfm xfrji gyjqyel");
            _inputPhrases.Add("lzypt jdbtrad ogr jdbtrad heink");
            _inputPhrases.Add("rcoucuq gdxewa rcoucuq whlw zhhm rcoucuq azaqohe mzyli rdvaf");
            _inputPhrases.Add("yuag ebcf yuag nsotg qqzuxr jfmao vyucw wmoye");
            _inputPhrases.Add("qwvk xemm hgqrr wyxkpp tojndm xlvzypw jus bgnu bgnu nklfwhs");
            _inputPhrases.Add("daqi knenmku ccm xkiuy vkexsbc kvvdagx umopitw yaocnx yoakqql mllmsp");
            _inputPhrases.Add("mrxgl gywit mfopia ncnsvw vdxek axuiot rsejua nei prndudz mnu");
            _inputPhrases.Add("egqn gaa qgen urs mix zbn rhn");
            _inputPhrases.Add("ewharq aihy udkdaob kgrdd kgrdd kugbjtj fcef llqb pduxaq wcexmm");
            _inputPhrases.Add("dwtiw nelq hppad algxgf gcc upou akm efnb mxmhrud");
            _inputPhrases.Add("yxqaa ups okbhgt iet qns tqn rnjqxgp");
            _inputPhrases.Add("npmhdm cgds ldexvr typi jyivoqk zkgq vfyxu xgfo");
            _inputPhrases.Add("dkwnmr umm dkwnmr okpjw wqx jpztebl eqsib dkwnmr");
            _inputPhrases.Add("dxbild wpbup evscivq dxbild dxbild geqp ojfbpl jshvqej");
            _inputPhrases.Add("cxdntxs csfocjd pyy tuhws teb boyloz xfw scxh pxhonky");
            _inputPhrases.Add("lteucke xrgwy hszgzu hnyrcvb");
            _inputPhrases.Add("pfgsgwg dxzh fworek qbstod");
            _inputPhrases.Add("usemcrf psczxu gcjtr brls");
            _inputPhrases.Add("hjol efxczux bqdn gvrnpey yyoqse gbam ndzyj lbwb bhzn unsezg");
            _inputPhrases.Add("bapw xifz blupk qqdk bofvqpp wnbuwyt rnwocu lzwgtt zucag pov");
            _inputPhrases.Add("xkre lqvd juf lqvd xio xyg xyg");
            _inputPhrases.Add("tzdao ztheib aymcf aorg iyawrch hetcxa iyawrch czdymc ccv");
            _inputPhrases.Add("ucgl azlppu jvxqlj pest");
            _inputPhrases.Add("dvwlw fuuy mnhmm okrp ualnqlm uyuznba fzyejk yaq crl ctprp");
            _inputPhrases.Add("odfq knox mkbcku pxucmuf lpjpol phl");
            _inputPhrases.Add("ixongh hfs ruorbd auy qyssl kykwcix aytsm rlj aytsm duq segpqhk");
            _inputPhrases.Add("izufsk wedpzh podjkor eamo vqvev ifnz podjkor xrnuqe");
            _inputPhrases.Add("twyfps bmdbgtu qye qkwjms");
            _inputPhrases.Add("wlav htym vhsnu cocphsj mdsuq vhsnu jflgmrp");
            _inputPhrases.Add("opajag itwjhfu purnnvk opajag");
            _inputPhrases.Add("hpkopqp vnj aialpt lzrkzfs nwucez nwuezc");
            _inputPhrases.Add("mcx hzcjxq zbxr dsx tpknx fva");
            _inputPhrases.Add("rlvgm xrejsvn ghawxb efyos xty wdzdgh olahbtn rga efyos vhtm nsr");
            _inputPhrases.Add("cni mbab qtgeiow ulttn rckc kmiaju jvbq emyvpew cdlxldn ulttn brhkprx");
            _inputPhrases.Add("eykpffp rapik qki fhjgdyu tome ehjuy bibjk htxd vexvag");
            _inputPhrases.Add("wrk dpxt gwkuiov gbkif ike gbkif pcd wpj toywyf qzsa aol");
            _inputPhrases.Add("yqwzh uujn ujun ujnu");
            _inputPhrases.Add("srs ralwxrz yxvvmgp sjhbhk waasid cqtxoxf whcladv jkmaq khjbsh dlavcwh");
            _inputPhrases.Add("mdvsjh xaj etvxlsy fxgiy rgjesel rlegesj ptriz ebdyhkp kugxm dxv egljser");
            _inputPhrases.Add("lhehwrs mqevb ygmv gri izop qgb ivm");
            _inputPhrases.Add("loqqam alojlwg hgen hbyw qlwpun loqqam worgnwk kope");
            _inputPhrases.Add("phozre todsknr todsknr ibj mvllsar");
            _inputPhrases.Add("wuripy ruwlfbh wukbkey qhq iishw tvtvci xawvxc vxacwx hsiwi ogq");
            _inputPhrases.Add("xryq vxwupqa zhqex aquxpwv bnvxrba dtbxki");
            _inputPhrases.Add("yvvwh zvsm vqskhp vqskhp ggqqlw bpn wbuv");
            _inputPhrases.Add("kqz tdy goqwge ygn jgd");
            _inputPhrases.Add("szjjhdk zkpoo nxexz ebicc");
            _inputPhrases.Add("wzuemcj oyd qupulju iaakzmt vzkvz");
            _inputPhrases.Add("nppahov umm wpzev wxkgfxd owgekp bhhb bbhh dgviiw kdfgxwx wryb");
            _inputPhrases.Add("bnc rhes lmbuhhy kwbefga bnc rtxnvz bnc");
            _inputPhrases.Add("ani mggxf mcoixh zdd nai hbhzl mes bdpqr");
            _inputPhrases.Add("mjn uinoty jjegvze bjgqg yhqsxbt coj obylb hddude xqi rhfbhha alood");
            _inputPhrases.Add("cbjzj drmihy tfkrhsd nuhav hihzx bvblqpl tdd szmp gjgfv box");
            _inputPhrases.Add("uumhdxd cmwgyf vepr rwqdkj exwk");
            _inputPhrases.Add("hwvr ydvw bqefu kghes gvbhp awms iqsqes khgse");
            _inputPhrases.Add("mrey jqfw fwvzhps komj dayvs fbui zmtd cofn mrey");
            _inputPhrases.Add("dsjds fdpx irjj usndok qcctsvf fgk wvg txwxcl dxs llp zyilwtq");
            _inputPhrases.Add("xmkelgk fdukc cye legkxkm wwly");
            _inputPhrases.Add("enlny eynln cccku brkz dpof mwfoxcd yftmnqh wpebvyc");
            _inputPhrases.Add("ggdn jnysl dsacffw ukj hdae cmzxku");
            _inputPhrases.Add("uqhm gcachmn kxndfrl htmfis jfnajz fiqiypr kekho kekho ndcw ckrndub dejfna");
            _inputPhrases.Add("keazuq ertql rauwl keazuq obmh rauwl ksrotm");
            _inputPhrases.Add("jppp poigqhv repfsje grjk xwkyuh pkx ayzcj hoxzv");
            _inputPhrases.Add("yhjw pcuyad icie icie icie hwcsuy wcd yihjh jnrxs");
            _inputPhrases.Add("gaug ivvx ceb xujonak hbtfkeb ttciml cctoz");
            _inputPhrases.Add("dggyyi dggyyi gqlyumf yasu fwdfa cbb nncn verhq");
            _inputPhrases.Add("rhgcw gpcyct kiuhbg kiuhbg gpcyct jlmleo nhumm");
            _inputPhrases.Add("wulxxu jyjek hclcp ogob viex wiqcupq");
            _inputPhrases.Add("tthu nxgzpid kcnj mss ukapgkp nnc bxjocv qwxs oejwsif aywqtu brahkb");
            _inputPhrases.Add("dtde bgvb smu vbbg zhlu");
            _inputPhrases.Add("lyo nwjjmep ldbok wgxhto wwuh qfgjknk wnsl");
            _inputPhrases.Add("lleyr onha hkwulbm jfg");
            _inputPhrases.Add("bybjwd uoxvbh mvj iqfpnxs bybjwd zqtszp wvc lbazjr zkzenja cev");
            _inputPhrases.Add("rbuyyr divtslq yuqmyt ajyveb smxsjb nlk tzqhq ims fewg wpjhr gqh");
            _inputPhrases.Add("kpewfd beq klilis klisli eeezut");
            _inputPhrases.Add("euqh hueq ldoo crqurv lvrwh tmaewp oodl");
            _inputPhrases.Add("bqi lzrf jyhvxfh bqi jyhvxfh nbztd lwpdn cuzi");
            _inputPhrases.Add("srjylou phavzjd wost uxkaq byh sluryoj");
            _inputPhrases.Add("ihrdk bcegkpq nygrs qbcq wyjg dvzme pgzhjl vibg kvv");
            _inputPhrases.Add("ijsx iedemek ktlz gtga tbal lbki gtga");
            _inputPhrases.Add("vmiaxn kefig kefig vngxz");
            _inputPhrases.Add("vrdmfvi qts vlvhq vlvhq dihmq");
            _inputPhrases.Add("cfz dyrz zlw qnt vok fwvahg skshbqf hbwozdc ntana jdb uflp");
            _inputPhrases.Add("rimbj bxemw sfps krtk umta vnk ewmbx nrlje ymrtqrz mxewb kjxunbt");
            _inputPhrases.Add("egnuti ozat eltl ngueti");
            _inputPhrases.Add("qtcwoxq rmaf qtcwoxq qtcwoxq");
            _inputPhrases.Add("zws gcoa pydruw qsrk lrkybdf ugr wkrxoj nyvf vitwn");
            _inputPhrases.Add("tmr hhd dojid zwrj bhsim righ keqlep flzunou");
            _inputPhrases.Add("lwoquvy acjowxk tqudk oenvioh nyavyl");
            _inputPhrases.Add("rgh dfhgyke iff cpxhuz hui koe iff hui dmukrei");
            _inputPhrases.Add("bjiumig lcbmbgh vleipx sfawua rnf");
            _inputPhrases.Add("gftfh qwb tfdroe xbno qhgofm vqfoe mux");
            _inputPhrases.Add("ljdrr gyfggai iun nju xrucbis mhrcrh fukr obvuqc whlalfe xrucbis nju");
            _inputPhrases.Add("nxjmjr egqwg arllu xqaahri lzc ivt uhsti");
            _inputPhrases.Add("sqiepba rcmts kvesv nvp");
            _inputPhrases.Add("tiksw tiksw rjni gbhvzm ctbq zuqfyvz");
            _inputPhrases.Add("ibsnm kfka aoqigwo sqouih rxz");
            _inputPhrases.Add("jmymq lxio adtmk umyu sxvzquq bporqnb heol fow");
            _inputPhrases.Add("mepa eckq rqviawv dkqoei ifmngpp jiava rtklseu");
            _inputPhrases.Add("yuycd jiufjci yuycd uowg yuycd udq izkicbr csxobh");
            _inputPhrases.Add("nwu tfsjavb rruoxbn oepcov elxf rruoxbn rruoxbn azglwth jcjm ksqiqpv");
            _inputPhrases.Add("dthfwip zqnwa zqnwa zqnwa");
            _inputPhrases.Add("gso wruece ufl crgnlxv vllsm dpyfm wpa ctxko");
            _inputPhrases.Add("wvpze seodz lpq lpq pmtp wsxs ffppx");
            _inputPhrases.Add("yfxquj phvjn rtwieq rtwieq kgxztyu vbjvkc prqqd lyzmdo ojbrt ojbrt qiqjz");
            _inputPhrases.Add("esaezr rpggiy jey kbzrhu uthus osr xxaiijd qfxlf auhzbx gkigoqw");
            _inputPhrases.Add("yfhcj uvgck cds gjhhrg cmempgj yfhcj cjb");
            _inputPhrases.Add("yxi voxvtuw unwg jqqm");
            _inputPhrases.Add("igvjr ljz rus sru gbjtjt qfeg ztu zjl");
            _inputPhrases.Add("leof ocxns hbkoysh hbkoysh leof");
            _inputPhrases.Add("hab lyxmf yhh qeks fwhfxki xmbcak okqjii nfgzyg bhtfgdj lpmjn");
            _inputPhrases.Add("mgognh tad herere lvwnzx ixwqs zphmuuc etdjz kczsf");
            _inputPhrases.Add("mtej rlolsnn zbl uykek dpkan gmz etxtgj");
            _inputPhrases.Add("mihuieo emjgbp jgks mihuieo iexrfw mjdnr bvp mcuzea xkbusvi");
            _inputPhrases.Add("jvqpj bwt jvqpj bwt gxr");
            _inputPhrases.Add("qpnd fpt tpor bibbpcg hmvguez wqc afl ckviua gpi");
            _inputPhrases.Add("dntmcg jglm sxtnu sxtnu sxtnu");
            _inputPhrases.Add("fzkbptw cbfwo ozvwov wbv gcdd izqo ovwzov lolewo xikqpw");
            _inputPhrases.Add("nkxyxzd kpn datf fki werq mwidqx oiibor zizcjph");
            _inputPhrases.Add("xvgyxym zor ijoy lvwsf fjuara idvvq rreit mqyyy ctio tzwqqhj rnpee");
            _inputPhrases.Add("maqkfpk maqkfpk xukg sfdmnlg xjopvr xjopvr irf");
            _inputPhrases.Add("liujcd vnlkouy dxkwc gto vhjvtw");
            _inputPhrases.Add("swhqhj cas aupsd swhqhj cas bvbooii jquck dtdm");
            _inputPhrases.Add("igh iqicicf ghi pcxt srcrjx gmf gyscphv");
            _inputPhrases.Add("drplj drplj wopgpnk wytag wopgpnk");
            _inputPhrases.Add("zexe ilcqoh qiefb txkuv lirfzv");
            _inputPhrases.Add("ovvpn ovvpn uqeurqx uwzn hgmucj ovvpn sjxulms");
            _inputPhrases.Add("rox silka irhsvym kutus otasof tdneav pcagds");
            _inputPhrases.Add("mkja omu tyshbfq onp trxs lxa tftbv bnpl djhnc zdqfs muo");
            _inputPhrases.Add("tjj rmmqas cbbkxs qio pikk ykyew gxlxt nhsyl ykyew");
            _inputPhrases.Add("frcprg njrz oaxcmhc qben pedm ecvtga nzxwpb ior gaklot dpem");
            _inputPhrases.Add("zyt kncau spoe qlchg sqys wkpbng yflju qlchg vkve bzadbpa");
            _inputPhrases.Add("qtq pkaicl qtq mfkfqvr dnleiq brrjxsx uoyxh pkaicl yvmlug");
            _inputPhrases.Add("firwy imtlp ywl qfa dqrbazz ztzb pcsbwhn zesmlag");
            _inputPhrases.Add("ivey ivey mtvc mtvc");
            _inputPhrases.Add("lhize acwf moa cdeoazd voktshy qmvqq jvmuvk ljfmq tsanygc");
            _inputPhrases.Add("xreiqkc aawrovl pofcsg xreiqkc xreiqkc");
            _inputPhrases.Add("cjbzvn ozds iniqu sdoz gqmki bablvll krs vjzcbn");
            _inputPhrases.Add("izsod htkeqz entxn qtns prpcwu omfnmoy");
            _inputPhrases.Add("kwfb tctzda aztctd tadtcz gyt wunbcub ydiwdin xxk");
            _inputPhrases.Add("epnl ijcp giq ltfk zjcabve zfksmz epnl giq xxxbsom");
            _inputPhrases.Add("ulyukpa mdjsbn dydko uhkdt qms aaaj hustlwu");
            _inputPhrases.Add("zlsbu ohx jcwovf egf zlvpqgx qhejm wrywdmw");
            _inputPhrases.Add("uhxqrzr mmu kjxcalj unuohiq rri yzngnb ikvlxry mfiym qbksdx");
            _inputPhrases.Add("khqciz som yklmm jceb khqciz jspy jceb");
            _inputPhrases.Add("ncwggv njvi nqox krtsn lnm");
            _inputPhrases.Add("bgtqme xaxcoq qbtgme obqual vorfk baoqul lgrb");
            _inputPhrases.Add("jli tsbb nlxjc pkwzmz dlxrj hmho gzguko ilj iyaasm");
            _inputPhrases.Add("wlmw grkumg dynwtyo emxhhqr huluk slpqu uhqcmd absmr ufirmwr");
            _inputPhrases.Add("pbs pcammxv dplfr tzvmav nccyy blvyq ffhnz bccutq");
            _inputPhrases.Add("hgge ghge vxmvz hqxgjdg zab guo gheg");
            _inputPhrases.Add("ylj bucoyoq udndc wpgyrbx ueh udndc gxdsdh hdoz wwgqlg");
            _inputPhrases.Add("cjdeh gttyqe kdkm ltzd lfeozse quvjq mnwhokm kdv oojxm nxt");
            _inputPhrases.Add("mfkzus knqxt saxkqww njx zumsfk sbmcyad cpt agvbuv");
            _inputPhrases.Add("tukn vyco yobvsn bzgnn klrnzy kea thzk pxpwq ryfff nxzm");
            _inputPhrases.Add("ylbm lxlz lybm lzxl");
            _inputPhrases.Add("wgtxoij zad slgsi cvnxfg iomswwl vmx");
            _inputPhrases.Add("hkm yinhnkj kmh kwkw kayknck chur styjif yknakck");
            _inputPhrases.Add("rtfwhkq rtfwhkq zsf zsf");
            _inputPhrases.Add("sldq zlntr ueegiw kajivqc ozcbm ceft snvugom pdyc elppeed nnqrp prwwf");
            _inputPhrases.Add("lhk xjonc muc tudag tsafx mmivb dvrjbp qgrew");
            _inputPhrases.Add("hnzer fbgqp aazta aazta lxaz lmgv aazta");
            _inputPhrases.Add("victgxu victgxu mlpd ummrnbx cazjgnw isxcyp efy zfa cyusj");
            _inputPhrases.Add("gyojxo onzq gyojxo uxufp awi ilhl wefwfxr gcjlt tmliynw uxufp pdcnxah");
            _inputPhrases.Add("wjwachn xkuhfbp oky oky ybaeqkr rbuix yreoaw wepmye brvon aasb");
            _inputPhrases.Add("kiidorw vxtxiqx wtqvbrv efdth isel qbom vcssyc vxtxiqx wtqvbrv riafzsw mqzsj");
            _inputPhrases.Add("eurpjd vkhdamt tmfx czeoot hiz ykz lmixzq tfur jhzr");
            _inputPhrases.Add("ipuftpj qbll sqkkdw fwncmiv bri oeeh lehd ioh wag");
            _inputPhrases.Add("suima nanngc imrmc krq atxdo woy atxdo akev qlr aezco qlr");
            _inputPhrases.Add("cfc efwbzck ozkmcxv moczkvx ccf");
            _inputPhrases.Add("bnekky iakrk sask uwgnjp iyi rynev bdnas ldh kass");
            _inputPhrases.Add("sicmw vvjbvv cap nsumc xgvrlm wsoo uoqdu psykckm");
            _inputPhrases.Add("ugg mtr wnzhmmh tjxc ehwnji lwhu mdsckk yvmk enubrqo");
            _inputPhrases.Add("grb oxmxz ohu ytetedv ssx apzlppg fdkamm sxofc jdt ynmu wyejok");
            _inputPhrases.Add("umoep rbyqm eqfk twqnog cptbbi dragna ngqs ffb cexxnc rbyqm");
            _inputPhrases.Add("utizi ormkel wvwur bdx ecelqbv xiccama aag glfvmj");
            _inputPhrases.Add("znb rsuqoa uxo svc");
            _inputPhrases.Add("obs lbifa cffi catpd");
            _inputPhrases.Add("qkxwian ajlzjz wewduzp bbyv qmt fsr qgiu epinp ghmf");
            _inputPhrases.Add("hatg bfgmb aght ghat");
            _inputPhrases.Add("kuq inp dun cknbun wmwsu drlmmg kyxc bdl");
            _inputPhrases.Add("bddybth swdbf jhi fva qpobio bjwm wjaztp jywi");
            _inputPhrases.Add("mgckz vhveu zkemhp zdf xtiqqew mlx wazgd");
            _inputPhrases.Add("umbjq pya lvvxf jeavij rhrxvew bwjqgpr piz");
            _inputPhrases.Add("xaycpwo vjcuc qksc yuixhni sfbfb dydyaq gdfvb tggg xidphvf bpjdrl goskxym");
            _inputPhrases.Add("agxfoip gguif wvo agxfoip ntkbaw fbyggy ooft zxih");
            _inputPhrases.Add("nzvsu ffwq uxvfbl qrql olhmhom qhdltg ymwz krtndtx olhmhom nfsv krtndtx");
            _inputPhrases.Add("qdp jqk ustz xjripzv mnk grnodk pjwdsj uug zqxjqj");
            _inputPhrases.Add("mufrcox zunisfs ocvcge acamm xua vor bsde kxr vor kxr orccxx");
            _inputPhrases.Add("ncycbp anvcxay bmm wndmeaw oso knmk mmb wamenwd kmkv ppdd");
            _inputPhrases.Add("motdcn xzagzwu vuzt utffrn yuqxzrh uvzt ujttq");
            _inputPhrases.Add("tauoqy coiy ybesz tauoqy wpmr trquyne ahxbj jzhems dsdy");
            _inputPhrases.Add("aczq ypw pgmzz srfn quatjgf");
            _inputPhrases.Add("cih ypapk bfxvr euvhkk gugru auhqui");
            _inputPhrases.Add("vyf pssgfvy dnhvbfl xpacme dnhvbfl mzdv iynq hcqu");
            _inputPhrases.Add("lbzvbu hhxiq hdfyiiz iyzihfd xhqih uzdqyxr");
            _inputPhrases.Add("iapbdll vdr cprmrkk vdr dfjqse mlry flpqk vdr");
            _inputPhrases.Add("grrfkq xcpxd grrfkq dxc bjpr prvwh swoc swoc");
            _inputPhrases.Add("bopo chvwuhf qhd ieesl xey ieesl fnjcbe");
            _inputPhrases.Add("kic fyq hsucnu agwyl pzzmd hqksh psw");
            _inputPhrases.Add("mxf uau iti lcoz lpg zbu ocre wqlocmh mxf nidqj lcoz");
            _inputPhrases.Add("bypmix ptzxgmf xmtzgpf hrvzzq");
            _inputPhrases.Add("lbfw zwusma lbfw tuyyy");
            _inputPhrases.Add("lrf uej unswvh obgsb npbl zajr kenea uej qnyjcu wzufim qpzkgya");
            _inputPhrases.Add("qcrxj llyu kligt hlm ehwtbx dda lgsvhdt xewfcv uikn");
            _inputPhrases.Add("nfzjx izqdbq mfbxs imiuc yqxb xlmvix izqdbq eflqfq wku omgtuu izqdbq");
            _inputPhrases.Add("lasdwg hiy btzt eefd eyoep icn nnmhg otml rek luixac nyzgn");
            _inputPhrases.Add("vekteds utsuxdx utsuxdx vekteds");
            _inputPhrases.Add("feyov qrij zbebwg ijrq seplram wttkwm zewbgb kzuhuh");
            _inputPhrases.Add("dmkgtv wohgqo ddtqmv zatahx mym hqowog tkmvdg");
            _inputPhrases.Add("vhha wjrmuyx kqh vyyrj xzchbi ejsdq orlxg vyyrj dlrc");
            _inputPhrases.Add("yetngqn zdtuqox hkarjei fqpsgh eaqwbg zsssog ghb gddqqzr hbg");
            _inputPhrases.Add("obldb zsrhz zxp uxphnev mwnbc pfjft fms xwslk vjm fxy");
            _inputPhrases.Add("nfij dbfykv ttq gyjgac igxuyqi gtiioqx ilhdex dbfykv uyp bdiwya gqf");
            _inputPhrases.Add("pffzruz vogfosh dcs wje");
            _inputPhrases.Add("pohhf fhpoh oon yyz");
            _inputPhrases.Add("xxuam afwm qxl lnt syyr bwxhhf sozauq shlhfmz kwnn milav ochq");
            _inputPhrases.Add("wefcqrt gejw cwerqtf fttf gjew");
            _inputPhrases.Add("jfsvnmr osca epwtle pgfif sxom");
            _inputPhrases.Add("exlfzmq nakp rgdnx rrcvth vhrrct aajjdrt ryyg dsozd jdqlqj pakn iruv");
            _inputPhrases.Add("rmcvo txszcs xxhyxz hbsozk wshkocf rmcvo rcbnt");
            _inputPhrases.Add("kitz yjgney yvkymef nauj hmllsgl kyhm kqr pzsu rcf pzsu qpte");
            _inputPhrases.Add("cdinpx bfur mkj naz ihkheyr nohhoe");
            _inputPhrases.Add("ylris xeqcgup wap bbfih tgfoj");
            _inputPhrases.Add("ina gnlnm zyeqhij cudfuf ipufae bvkdzni aat teqsg cudfuf bjokrbl teqsg");
            _inputPhrases.Add("aedx edax dnfwq qndwf");
            _inputPhrases.Add("rdngdy jde wvgkhto bdvngf mdup eskuvg ezli opibo mppoc mdup zrasc");
            _inputPhrases.Add("qcnc iaw grjfsxe gnf gnf");
            _inputPhrases.Add("zbjm snznt zelswrk gkhlnx dqxqn qqxnd dmro");
            _inputPhrases.Add("zisecvx ztezof uzbq otnrtj qsjzkwm ewvcp rlir bfghlq tgapdr qxmr");
            _inputPhrases.Add("ipnqj opjf vabyoe wkwnd");
            _inputPhrases.Add("wyf mfqxnrf apm snarf jqu aaghx pwecbv lvghayg");
            _inputPhrases.Add("acncv jmmbwlg oiphlm ifuo cvt");
            _inputPhrases.Add("pvmb egansnd zmh gcuzzci rrxpslv ubith");
            _inputPhrases.Add("uoleptg xbouzn xbmg cfh cpn wpqi xbouzn xtxis sxzpns");
            _inputPhrases.Add("rilybri kurbpq vfmjpck tjyogho hfyxad svfofx lfbbhxj khaerfs iqr");
            _inputPhrases.Add("seaebgz wlmtkre qguv qguv wlmtkre");
            _inputPhrases.Add("sgo edkxya zdqgwtt gxu nibuu rairqoq mzxli dci qsv");
            _inputPhrases.Add("tsol mdhzqr rmaqnru ggvcq arbwkn hlkcnj ljkcuof");
            _inputPhrases.Add("mmliphp ocup puoc eijjv");
            _inputPhrases.Add("gmajqpb ijki ijki kvz");
            _inputPhrases.Add("pmqss unhlpcj dlkll nuhlcjp expe tlurzmv nsy vlumtzr tgseozl");
            _inputPhrases.Add("gkvaoni hsba hsba viuedv phyoclp fdq phyoclp febld nqfs");
            _inputPhrases.Add("rxvdtw abn pntv qrqfzz slsvv abn lrxix mnu npot");
            _inputPhrases.Add("ghlfjp woy xwkbmv bkahpkj jve cncvk jvdype fwgvoju yrkwjp gwfvln mvkv");
            _inputPhrases.Add("kmluh mie bby fwer chsinb ojglqr nqk mie");
            _inputPhrases.Add("yzmiu igkgca ybnsqja jpfejtp yjddy xsosxfi ingx qwuhb emrkwpx idqjmmm");
            _inputPhrases.Add("btrllw mphm dkvo ewdl dchcul yah btrllw kmqi mtvgk wtb");
            _inputPhrases.Add("hxsgard yuikc lykt tdee adprp gpougod klnzk mzsmlb");
            _inputPhrases.Add("hdn znblw ifoblur bwzln dbv");
            _inputPhrases.Add("smofpbs vjuyiro llk lfzesga tybu tybu");
            _inputPhrases.Add("gffnpug xaup iqiyz fjkpnkz drrk fwyxw lwzfskz gslwpmv vjxylva tbkyo nib");
            _inputPhrases.Add("evydmb nhwuiiu fkerq nkgbuyy uclrs ydjgglh xhotwbm riirgzt");
            _inputPhrases.Add("bsub eavbt uvd dpzwyt rhn khrbptt xszckc djnfxju axofhat powmso nvdffrv");
            _inputPhrases.Add("xtuykl fjz mbikc xpnx hmey fjz fjz");
            _inputPhrases.Add("rkls nwdcsyx rkls rkls");
            _inputPhrases.Add("tygml untequ ybdfumz nqffbq uipc sove hfnqj");
            _inputPhrases.Add("ytecew vven koqn royynd qsn ksl qsn sdw");
            _inputPhrases.Add("hknlw qwho whoq oqwh");
            _inputPhrases.Add("lzmmtqu qvhyeo cnofuj utpwkjz gnirz yhhu aodbnd");
            _inputPhrases.Add("zsr axw kwtzcv tydzo kwtzcv lkxsm");
            _inputPhrases.Add("rbjtqe nihifd gvdxd bpxzy rxteky vgcgllv vbbua anygiup rqo");
            _inputPhrases.Add("dpd wblfwp wblfwp wblfwp ygahc tqjbaq");
            _inputPhrases.Add("gsw gsw pacgj xmrcz zmxhmch xmrcz");
            _inputPhrases.Add("pdq rhe xqmq lgpkhg fyffrot ovnqh wle");
            _inputPhrases.Add("tbjavke ypzzrj jizx gdxoh icjsat otfh fmygumv");
            _inputPhrases.Add("snch nxlgjgp jeyn sxoqfj jtage jtage iuice");
            _inputPhrases.Add("rtb coefuj grwg grwg rtb krhqnma vfhgbr");
            _inputPhrases.Add("vhegtl btorwxg szcev kbvkx itsk nlzpbed");
            _inputPhrases.Add("hiukrf ilzkm yllhh xsgwkdp zyy kjbv");
            _inputPhrases.Add("rfcg tdorci zcj wzftlv rfcg rfcg");
            _inputPhrases.Add("lgbc lzizat vsno pau nvv vsno bbr lzizat qhtb gwp");
            _inputPhrases.Add("sfwnio tcugjk bsfsz ykyfwg ibkap fsrvy mygk kzunawx zyhyh");
            _inputPhrases.Add("mpavlh qps bylh lttjkz rqabgk vewb bwev tlzkjt gzrbxga ktmso prpkj");
            _inputPhrases.Add("gpf ims ynh ffrs vpa iemp gofh cgbauje");
            _inputPhrases.Add("secys qks mcnfhwh drog kqs pajy zoltkw lfihnb myb ioxptu");
            _inputPhrases.Add("ytq nrta ouk ajqblf yuwwcd zdy blyoxbw dakk nvgi bzrhzaa");
            _inputPhrases.Add("nkoych sufiia xkdvw crtldee zycl qblab egqhr qblab");
            _inputPhrases.Add("nllno muxaf vds qjnitmw zkpj wskyhft kmqct xamuzpw qcai cdjtbt kaxv");
            _inputPhrases.Add("qzdytpe osr fuw osr qzdytpe whperd rydwdcl knoa");
            _inputPhrases.Add("zkdznhd peh duoygr zamrgl irnvj otpe pltpq jdkecg");
            _inputPhrases.Add("byzgw rece iigdug ehif tpgje");
            _inputPhrases.Add("ccnn foqdran gbctca tefdjxh ntcr rjciii xip xlss crl wvvhzqm twyohf");
            _inputPhrases.Add("dqyii milqqc qjgkojp qjgkojp ryde");
            _inputPhrases.Add("tdkyj tbrcud tsba vqtmb cjwxnf");
            _inputPhrases.Add("hqhmq wemvrce nagig pwnw nagig epg nagig vlsi");
            _inputPhrases.Add("tqgvw luoplw hccti npjm rytdruq cylrsun rytdruq vjsbjl rytdruq ppti");
            _inputPhrases.Add("itgt tuwc itgt rvp itgt tigns eipl ksmru");
            _inputPhrases.Add("pdw wdhtkn nbdbpn wff zhuuipg rvemv qxr");
            _inputPhrases.Add("qgkwdq cjilayh ymeks mrpuzai dwgs stfstgz ucvqhb yout oiq");
            _inputPhrases.Add("vpxik ypfr qytimvu qms oxbmw ppyfx");
            _inputPhrases.Add("fwwidn gdhd pyuexk snsz iwndfw");
            _inputPhrases.Add("lfcb sllxjna lfcb hpzahfg mmvgaa svny jhuzd");
            _inputPhrases.Add("unyg gicmzd fwc spkciy toyq wjupckd vzzx iuqgka ytqycb pxsufj");
            _inputPhrases.Add("goj tnrcml eyizngj txa xrkiw zvu igduz");
            _inputPhrases.Add("wek xrrlkna clyof rrlnxak");
            _inputPhrases.Add("cjm rmyuku vjom gtf");
            _inputPhrases.Add("buk cfae awstd dywgqp hxo wcxvf laihqw xdqfes wdbh qceh uzlwj");
            _inputPhrases.Add("sudguo dxwplto rlebdh bkamu dxwplto");
            _inputPhrases.Add("crwkyxm yuz kjtdhom crwkyxm");
            _inputPhrases.Add("trhc sduorxr aizfryh rsudxor gbyc");
            _inputPhrases.Add("pczkyl bptp qnn nxmpwsx udrg hhlb rubtrmx twzodlp xygnht");
            _inputPhrases.Add("jmqct cden yfajtkz fevcw sxonbxz sxonbxz qkzkm hhngr fbv");
            _inputPhrases.Add("sdsnm mwvicr wypfi cty ndbowr woiz mrauwzd qlno mwvicr");
            _inputPhrases.Add("vteyo fng lvr lxytn txpj milg");
            _inputPhrases.Add("wjx ahtmgo cgwcaj kaxae fhlvlqf");
            _inputPhrases.Add("ezj eetqhzu upwda iiefwlk vyvby");
            _inputPhrases.Add("imalvy yeghqe jwcu mvrod cwju");
            _inputPhrases.Add("bxnmsa yhfu npsdar tsbri hfuy sirbt oofxmy");
            _inputPhrases.Add("fkndt elbjtn vepqtxt elvpf fpelv bzkgag qttexpv prblwb");
            _inputPhrases.Add("rmq iqs yvprnyy iezqrzm wlqsrr");
            _inputPhrases.Add("yviovq lekxghj oey qwhzj lxknxw qiyovv ksnt jptz");
            _inputPhrases.Add("tyrg cifxt hugqf tyrg ffuiv jmax qyw fozfosq ffuiv");
            _inputPhrases.Add("nmg rsl jpzazd qbtlf yxqtsj czwmdfd bamge lbjdof uqy jssc");
            _inputPhrases.Add("cbx boozjip pwgvzlq rjz kxy kxy hszacok fvsq jhnir cnsba gafz");
            _inputPhrases.Add("sbcuxb wfur nnnfqjj fdwg huhe sbcuxb");
            _inputPhrases.Add("icwk qelbxs uevp qped zsnhh wpuok wddxsln ftnzupr ruxol cgxjb jbhh");
            _inputPhrases.Add("izcp htykj xxmndoq amnspe htykj");
            _inputPhrases.Add("vverol oixwlny vqd tvfzu henc gnyrwr");
            _inputPhrases.Add("ytxio etytsx choynep zqapo hfjit");
            _inputPhrases.Add("lkvgr oyzfa taiqr jok djatvy ckif tmdw oyzfa zroy");
            _inputPhrases.Add("jlgpyp kkqysg oqjki hjohoug hbhta muilz zft");
            _inputPhrases.Add("sumfyu wftcu bwwdcy lezimwa qwvxv zwh mqyv bmfot aii torcol rnt");
            _inputPhrases.Add("tpdj xrw ccsbnh fhptv fwkxjfm dmqaokd bjci");
            _inputPhrases.Add("zxi vmf vmf dpyg");
            _inputPhrases.Add("sfzxysw lcms bkojtv bkojtv");
            _inputPhrases.Add("opywo qll ipkitr mtwp tudrr svhyp huz bxsdpn xomfy");
            _inputPhrases.Add("gkod luo qrosbp orbd rpsjzyd rlh gdok tze");
            _inputPhrases.Add("nusiuq nusiuq zeys ahufexc");
            _inputPhrases.Add("veno jntg avtmtdn qojxru zegdcql odfcetz pgehau");
            _inputPhrases.Add("uqun vigjm ykac ozlelj danmji bibugox");
            _inputPhrases.Add("rpuozh ajwru rbvuevv uhzsq");
            _inputPhrases.Add("iawoe tyb aewio ymf byt inijv ctu fcys micsgzl pbby alt");
            _inputPhrases.Add("gktyxp ris mqpfm bkqsfl nrg idbbcxg jhcf");
            _inputPhrases.Add("qibt invvv qibt luitx rnm eby hrfbmwl wnap sgkzvb qlwc hrfbmwl");
            _inputPhrases.Add("jwkv qecsjbw lycgldd wjvk tjcp dycldgl pzrvr zrlcf kji");
            _inputPhrases.Add("nzsrmiq nmhse ilivrk kqv");
            _inputPhrases.Add("besmyzi imkgpt iekbjax abxeijk uvzs wwv");
            _inputPhrases.Add("jdocl uki ltswp tjkljc ymce iuepze qygqxzs tei lkry");
            _inputPhrases.Add("hhyfy gvzd mqksxlq czn afe mesnag eep frwgekg mqksxlq phpy");
            _inputPhrases.Add("ehg connnza ekt ddgokw");
            _inputPhrases.Add("mpbsoms uzhzl xevww ztt uzhzl");
            _inputPhrases.Add("lftybr firc awsud dsxdkk ltf ipjv dtx lcymth");
            _inputPhrases.Add("vkcpb gxtxq yioeq fexj xxgqt");
            _inputPhrases.Add("srvca fslnnvf nfmkpvt egw wemumq jie vznf dzsjw cukf kcvyir");
            _inputPhrases.Add("yxjkl lyjkx jyxlk kgc xtz");
            _inputPhrases.Add("tpoe xzov csp leleoqo noyre tdhf cyib sjgtdx raehdw nmcxp");
            _inputPhrases.Add("qvt uhznqe bpvos vtq ddlebtd tqv");
            _inputPhrases.Add("xlw utsxs gpia rvlvnts elkxr dddihy tnrslvv ibf wlx bxg");
            _inputPhrases.Add("cwqnnrt rkkqyf dye yde fzl pthanj");
            _inputPhrases.Add("boc rqjenpp xjqte jteqx pvoofc pidqe ruoucy gvnro ognrv");
            _inputPhrases.Add("qhalb gnazwc fhl iuti");
            _inputPhrases.Add("clnbjfo nnfs nnfs heymvr oarew oarew nxu");
            _inputPhrases.Add("lwtrotg hiaxwj ymzbly nvhzjhj zlsaheg nvhzjhj ymzbly");
            _inputPhrases.Add("rrvi tsjp tsjp tsjp killji");
            _inputPhrases.Add("rpx hiclj cmwq ibhj nfd");
            _inputPhrases.Add("pvwymn iebkd xmpw vuhhkap ksw zigzy mzzyyxy rmuh iwwhea cglfq");
            _inputPhrases.Add("rlwelgy sffml jin qsdzro xlsty mgqzuu etxjuo emzd jgnoyq tkjuy vfvb");
            _inputPhrases.Add("tkctdj hhkuc viskmy obw");
            _inputPhrases.Add("zvjkuj akeky ikj jqd hfhzbwe bkc");
            _inputPhrases.Add("btev nrdo hcyiuph stf qharfg vpmel mpfz nvs ytgbbc");
            _inputPhrases.Add("ieepn ndueuw svmdr tcvumw mceyrn mrjwhyl tbdj mgrgvz");
            _inputPhrases.Add("uxrs ckyi xpmqm czzrkl cjp");
            _inputPhrases.Add("nlliwd wrqkrkz yjmng nlliwd zirde hcjjn wco ysf mgl");
            _inputPhrases.Add("dxti lcahe ommare izlwf ramsfb nzgfvo ijvm fwymrdu bndq");
            _inputPhrases.Add("isxy jpvuzu tdduyhw dixp cfa fkzbteg ytoi kepk ysf yqcpi");
            _inputPhrases.Add("qmeprfj soqo ncgeor cqsuuj grzy wogxy vyblnbg slvtry vdols kka");
            _inputPhrases.Add("ltykfp gtzl olrp gxend vapee deq");
            _inputPhrases.Add("emywfbn dbfiut rkt wvwe dbfiut bwffhea yuzcxv gogpicp wvwe");
            _inputPhrases.Add("vqvmrp ofbk dlfabd jwllzxk obx vqpwjj umvng tqwis fstxy fstxy");
            _inputPhrases.Add("miha zgvyux rmraszo xwf");
            _inputPhrases.Add("kjaagk btm kjaagk wkewjrg kjaagk");
            _inputPhrases.Add("lbmli aizs omrdr gzktnx asiz ptanzpa xlo ljre ckyb wob");
            _inputPhrases.Add("svz dlk rijagg avxmg fkzwhk uro gegm");
            _inputPhrases.Add("dzplum temdw jqnm tvxcww bmg tftttpp deuw comxey xfimzjx caluczi nqn");
            _inputPhrases.Add("uwvhxa ztkd nlsdyt vihl julkwwv uzch dwakhs");
            _inputPhrases.Add("wkhuihh ycrc cxff vzcfhpp uegfd gaok kcnvz lhzogq lwa tyrypvu");
            _inputPhrases.Add("idp zmrrzp zmrrzp nktp xsnx rjsxn");
            _inputPhrases.Add("eybrnib ivgntl vaxsbpi eybrnib");
            _inputPhrases.Add("nzvnq xvbfa pbhwwh ylju runvsj imlx vztesn");
            _inputPhrases.Add("nfdohd nfdohd gtevnky pivjyct ihvd fzcsrq lko fmqk");
            _inputPhrases.Add("kwpkks ecikxu bcxswlt qvrxm sbcqmh");
            _inputPhrases.Add("kdjrmj piuh kdjrmj vnaf gyedkg vptxgm xezssxx zsg qjzpo zsg");
            _inputPhrases.Add("oqo sley aqx qmpqb fgmylbj egd zivj kepxizv kuakyn lunbnd");
            _inputPhrases.Add("hmcf hmcf xlhgc hmcf cdlm buofnx");
            _inputPhrases.Add("onjcj yluonz kzmk phqo phqo phqo");
            _inputPhrases.Add("ohaafy efl bnkkjww wwjnyoj dxeaig ywnjjwo slk hrbebw ohlyju elf");
            _inputPhrases.Add("msohiqz aunk njki bfktdgi htmyrj mgx");
            _inputPhrases.Add("numlzrl rmnlulz glb ltt fhbajz gqxpu");
            _inputPhrases.Add("gko hco oai ryq xwy sdqosft spjkiu cxfhg ycwpglh noy rah");
            _inputPhrases.Add("btzpjem brpk vqr atxu rhlh rqv jmg fvyus");
            _inputPhrases.Add("phmxxgj ejx xje qtk hsb kqt npwj gqt");
            _inputPhrases.Add("hujyjp nwmsd ant zipuya lrkahww uwqal vzlo qmbo twkjkse ufivi");
            _inputPhrases.Add("zfbnyz fwvh xrnrw usn zin daq iwjzj");
            _inputPhrases.Add("yykyg iwypfy hehqnl cjvk cevdrec");
            _inputPhrases.Add("gui muuto wsta glqmx gfo rdmbv mxwz gffzt eejpw gion");
            _inputPhrases.Add("lpng nduid iqbpu nduid knrqd");
            _inputPhrases.Add("xwxn oefpckv gjaua ugaaj gjuaa");
            _inputPhrases.Add("qxk aeql trqdmqc crzlinj crzlinj trqdmqc rijcne ewyf");
            _inputPhrases.Add("rfv qmbe fvr bmeq");
            _inputPhrases.Add("upqyfw lowzq wpen upqyfw gfskbil sljuzh wpen");
            _inputPhrases.Add("bdcara qyhx rtaez qyq gbyr");
            _inputPhrases.Add("evzls qxtxq clzd svbgqi zxlzgss vtrre fko eebo qjyl");
            _inputPhrases.Add("zaapeo kpwhz tygknau nyd pch trp xqe");
            _inputPhrases.Add("ypzcafg rnqmbh qtteg sncu ssojhhm zonfym thir xmgheb wqj gpjg ssojhhm");
            _inputPhrases.Add("wvcwyn xrf muozyya lasdp xpjgu kpqv zkiihiv ifje cbdlavg xbied hfnaa");
            _inputPhrases.Add("qqqb rettz rycukl ihpkhh");
            _inputPhrases.Add("dnxzxqv znb znb fbxj azxtezb xvxa");
            _inputPhrases.Add("peqkd xlzqkov esgnw ucku hrwpfxd xtd vnig vlmfp ajte qswr kqoj");
            _inputPhrases.Add("dpwy oavzkk dwyp ehij upqxgii pydw");
            _inputPhrases.Add("amfc hfv xmqa nqvn cal rqmcq oej amqx cla ntxj");
            _inputPhrases.Add("hqhhe qkbhwli wmhlcq xaczs peywuo");
            _inputPhrases.Add("vcr xfv xfv kymo qpszwzo xfv");
            _inputPhrases.Add("nmrbur tswo xbo ljlrzo bmhpgc pev zovkznz lok wbbhtkk");
            _inputPhrases.Add("tojj lxqgr rhjavrm ndsdup gdbjwaq cqpnl wfaxivl rfry ryfr udspnd");
            _inputPhrases.Add("beffod sknlph amb feobdf");
            _inputPhrases.Add("mldgn jxovw yuawcvz kzgzwht rxqhzev fsdnvu vluuo eycoh cugf qjugo");
            _inputPhrases.Add("tlnd qcxj ker fdir cgkpo nrqhyq raef uqadf iahy rxx");
            _inputPhrases.Add("mhvisju lhmdbs tcxied xeidtc ujry cditex gvqpqm");
            _inputPhrases.Add("cgc jazrp crgnna uvuokl uvuokl uoiwl sknmc sknmc");
            _inputPhrases.Add("rvbu czwpdit vmlihg spz lfaxxev zslfuto oog dvoksub");
        }
    }
}
