function Translate(eng) {
    var ret = "";
    var strarr = eng.split(" ");
    for (var i = 0; i < strarr.length; i++) {
        ret += strarr[i];
    }
    ret = ret.replace(",", "，");
    ret = ret.replace(".", "。");
    ret = ret.replace("?", "？");
    ret = ret.replace(":", "；");
    ret = ret.replace("-", "");
    return ret;
}

function Read(chn) {
    return "http://tsn.baidu.com/text2audio?tex="+chn+"&lan=zh&cuid=aaaascasc&ctp=1&tok=24.3ca118e2b9bb3fe63885ed35f97b4473.2592000.1438357067.282335-6345082";
}