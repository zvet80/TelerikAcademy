//
//  Display.h
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import <Foundation/Foundation.h>

@interface Display : NSObject

@property double size;

@property int numberOfColors;

-(instancetype) initWithSize: (double) size
           andNumberOfColors: (int) numberOfColors;

+(Display*)displayWithSize:(double)size andNumberOfColors:(int)numberOfColors;

@end
