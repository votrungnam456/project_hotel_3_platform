import React, { Component } from 'react';

class introductions extends Component {
     render() {
          return (
               <div className="container">
                    <h1 className="title">Introduction</h1>
                    <div className="row">
                         <div className="col-sm-4">
                              <p>Aaroma hops ester becher, terminal gravity. crystal malt top-fermenting yeast carbonation dry stout cask conditioning. abv ester cask conditioned ale dry stout, attenuation bottom fermenting yeast. scotch ale wheat beer glass saccharification crystal malt. top-fermenting yeast hydrometer, degrees plato chocolate malt. wit dunkle, grainy aerobic kolsch; draft (draught) real ale.</p>
                         </div>
                         <div className="col-sm-4">
                              <p>Fale acid rest bock, " trappist biere de garde," infusion oxidized, carboy. hard cider, crystal malt hoppy pitch alpha acid dry stout tulip glass fermentation. bitter malt extract, dunkle, squares. units of bitterness trappist wort chiller keg krausen ester. brewpub. cold filter length, alcohol copper degrees plato aau.</p>
                         </div>
                         <div className="col-sm-4">
                              <p>Dry stout aau pilsner. bock cold filter lauter tun specific gravity degrees plato ibu cold filter. brew kettle crystal malt, hard cider ipa bright beer caramel malt. pitching aerobic keg finishing hops pub units of bitterness.</p>
                    </div>
                    </div>
                         <div className="spacer">
                         <div className="embed-responsive embed-responsive-16by9"><iframe className="embed-responsive-item" src="//player.vimeo.com/video/55057393?title=0" width="100%" height={400} frameBorder={0} webkitallowfullscreen mozallowfullscreen allowFullScreen /></div>
                    </div>
               </div>

          );
     }
}

export default introductions;