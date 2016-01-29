//
//  Display.m
//  phones
//
//  Created by z on 1/28/16.
//  Copyright © 2016 z. All rights reserved.
//

#import "Display.h"

@implementation Display

-(instancetype)initWithSize:(double)size andNumberOfColors:(int)numberOfColors{
    self = [super init];
    if (self) {
        self.size = size;
        self.numberOfColors=numberOfColors;
    }
    
    return self;
}

+(Display*)displayWithSize:(double)size andNumberOfColors:(int)numberOfColors{
    return [[Display alloc] initWithSize:size andNumberOfColors:numberOfColors];
}

-(NSString *)description{
    return [NSString stringWithFormat:@"Display Size: %f, Number of colors: %d",
            self.size,
            self.numberOfColors];
}


@end
