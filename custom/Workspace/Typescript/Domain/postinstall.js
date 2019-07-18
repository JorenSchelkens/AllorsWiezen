#! /usr/bin/env node

const path = require('path');
const lnk = require('lnk');

function link(src, dst){
    const basename = path.basename(src);

    lnk([src], dst)
    .then(() => console.log(basename + ' linked') )
    .catch(() =>  console.log(basename + ' already linked'))
}

link ('../../../../allors/Platform/Framework/Typescript/framework', 'src/allors');
link ('../../../../allors/Base/Workspace/Typescript/Domain/src/allors/domain/base', 'src/allors/domain');
